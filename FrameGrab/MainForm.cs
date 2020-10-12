using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameGrab
{
    public partial class FrameGrabber : Form
    {
        public FrameGrabber()
        {
            InitializeComponent();
        }


        //Make the size of the picture box the same as image
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

      
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;


            var isLoadSuccessful = monoGamePanel1.LoadImage(openFileDialog.FileName);
            if(!isLoadSuccessful)
            {
                MessageBox.Show($"Invalid file: {openFileDialog.FileName}");
            }
        }

    }
}
