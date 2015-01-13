using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraFolderCreator
{
    public partial class Form1 : Form
    {
        int numOfFolders = 100;
        int startNum = 0;
        String folderParentPath;
        //String pattern;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateFolders_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    numOfFolders = Convert.ToInt32(textBoxNumberOfFolders.Text);
                    folderParentPath = folderBrowserDialog1.SelectedPath;
                    startNum = Convert.ToInt16(textBoxStartingNum.Text);
                    createFolders(numOfFolders,startNum);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("input is wrong");
                }
            }


        }
        private void createFolders(int numberOfFolders,int start)
        {
            for (int i = 0; i < numberOfFolders; i++)
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(folderParentPath, (i+start).ToString() +"CANON"));
            }
            MessageBox.Show(numberOfFolders + " folders have been created");
        }
    }
}
