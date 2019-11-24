using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifOptimizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //browse and show image
        private void browseBtn_Click(object sender, EventArgs e)
        {
            //display OpenFileDialog to select gif
            OpenFileDialog openFile = new OpenFileDialog();
            //filter just GIF files
            openFile.Filter = "GIF Files|*.gif";
            //title of OpenFileDialog Window
            openFile.Title = "Select a GIF Image";
            //show dialog
            //if user press ok the open GIF file
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //show image on picture box
                sourcePath.Text = openFile.FileName.ToString();
                using (var fs = new System.IO.FileStream(openFile.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    var ms = new System.IO.MemoryStream();
                    fs.CopyTo(ms);
                    ms.Position = 0;
                    if (sourceGif.Image != null)
                        sourceGif.Image.Dispose();
                    sourceGif.Image = Image.FromStream(ms);
                }
            }
        }//end browse method here


        //save value on closing form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save our setting
            Properties.Settings.Default.Level = compressLevel.Text;
            Properties.Settings.Default.Lossy = Convert.ToInt32(lossy.Value);
            Properties.Settings.Default.Colors = Convert.ToInt32(colorReduction.Value);
            Properties.Settings.Default.Width = (Convert.ToInt32(gifWidth.Text) <= 0) ? 320 : Convert.ToInt32(gifWidth.Text);
            Properties.Settings.Default.Height = (Convert.ToInt32(gifHeight.Text) <= 0) ? 250 : Convert.ToInt32(gifHeight.Text);
            Properties.Settings.Default.Save();
        }

        //on form load set properties values
        private void MainForm_Load(object sender, EventArgs e)
        {
            compressLevel.Text = Properties.Settings.Default.Level;
            lossy.Value = Properties.Settings.Default.Lossy;
            colorReduction.Value = Properties.Settings.Default.Colors;
            gifWidth.Text = Properties.Settings.Default.Width.ToString();
            gifHeight.Text = Properties.Settings.Default.Height.ToString();
        }//end form load method here

        private void BrowseOutPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Outputpath.Text = fbd.SelectedPath.ToString();
                }
            }
        }



        private void OptimizeGif()
        {
            string filename = outputFileName.Text;
            string outputPath = Outputpath.Text;

            if (string.IsNullOrWhiteSpace(filename.ToString()) || string.IsNullOrWhiteSpace(outputPath.ToString()))
            {
                MessageBox.Show("Please provide output filename and path");
            }
            else
            {
                string ExeToUse = string.Empty;

                if (Environment.Is64BitOperatingSystem == true)
                {
                    ExeToUse = "gifopt64.exe";
                }
                else
                {
                    ExeToUse = "gifopt32.exe";
                }

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.FileName = ExeToUse;

                string CompressValue = compressLevel.Text;
                StringBuilder ArgsString = new StringBuilder();

                ArgsString.Append(" -O=" + CompressValue + " ");
                if (lossy.Value > 0)
                {
                    ArgsString.Append(" --lossy=" + lossy.Value.ToString());
                }

                if (colorReduction.Value > 0)
                {
                    ArgsString.Append(" --colors=" + colorReduction.Value.ToString());
                }

                if (gifWidth.Text != "0" && gifHeight.Text != "0")
                {
                    ArgsString.Append(" --resize-fit " + gifWidth.Text + "x" + gifHeight.Text + " ");
                }

                ArgsString.Append("\""+sourcePath.Text+"\"");
                ArgsString.Append(" -o "+ "\""+outputPath+"\\"+filename+".gif"+"\"");

                //MessageBox.Show(ArgsString.ToString());

                psi.Arguments = ArgsString.ToString();

                Process.Start(psi).WaitForExit();

                using (var fs = new System.IO.FileStream(outputPath + "\\" + filename + ".gif", System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    var ms = new System.IO.MemoryStream();
                    fs.CopyTo(ms);
                    ms.Position = 0;
                    if (optimizedGif.Image != null)
                        optimizedGif.Image.Dispose();
                    optimizedGif.Image = Image.FromStream(ms);
                }

            }//end check else here


        }//optimizegif ends here

        private void optimizedbtn_Click(object sender, EventArgs e)
        {
            OptimizeGif();
        }

        private void sourceGif_Click(object sender, EventArgs e)
        {

        }
    }
}
