using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassHierarchyViewer
{
    public partial class classViewer : Form
    {
        public classViewer()
        {
            InitializeComponent();

            dataManager = new DataManager();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dataManager.SetRootFolder(folderBrowserDialog1.SelectedPath);
            }
        }

        private void generateHierarchyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( !dataManager.GenerateRootHierarchy())
            {
                return;
            }

            return;
        }
    }
}
