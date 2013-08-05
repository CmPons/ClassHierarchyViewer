using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassHierarchyViewer
{
    class DataManager
    {
        public DataManager()
        {
            m_rootFolder = "";
            m_hierarchyTree = new HierarchyTree();
        }

        public void SetRootFolder(String rootFolderDirectory)
        {
            m_rootFolder = rootFolderDirectory;
        }

        public bool GenerateRootHierarchy()
        {
            if (m_rootFolder == "")
            {
                MessageBox.Show("The root folder must be set first!", "Error");
                return false;
            }

            return true;
        }

        private String m_rootFolder;
        private HierarchyTree m_hierarchyTree;
    }
}

