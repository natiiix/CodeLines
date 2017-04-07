using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLines
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            openFileDialogSelect.ShowDialog();
        }

        private void openFileDialogSelect_FileOk(object sender, CancelEventArgs e)
        {
            int lastBackslash = openFileDialogSelect.FileName.LastIndexOf('\\');
            string dirPath = openFileDialogSelect.FileName.Substring(0, lastBackslash);
        }

        private void processDirectory(string path)
        {

        }
    }
}
