using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassHierarchyViewer
{
    
    class HierarchyTree
    {
        // Contructor
        public HierarchyTree()
        {
            m_bTreeEmpty = true;
        }

        // Generate the tree from the specified root directory.
        // Each Treenode represents a C++ header file.
        public bool GenerateTree(String rootDirectory)
        {
            GenerateFileList(rootDirectory);
            m_bTreeEmpty = false;

            return true;
        }

        // This function finds all the C++ header files in the root directory
        private void GenerateFileList(String rootDirectory)
        {
            DirectoryInfo dir = new DirectoryInfo(rootDirectory);
            DirectoryInfo[] subDirs = dir.GetDirectories();

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo fi in files)
            {
                if (fi.Extension.Equals(".h"))
                {
                    m_fileList.Add(fi);
                }
            }

            if (subDirs != null)
            {
                foreach (DirectoryInfo sd in subDirs)
                {
                    GenerateFileList(rootDirectory + @"\" + sd.Name);
                }
            }
        }

        // Utilities
        public bool IsTreeEmpty() { return m_bTreeEmpty; }

        private Treenode m_root;
        private bool m_bTreeEmpty;
        private List<FileInfo> m_fileList;
    }

    class Treenode
    {        
        // The file this class was found in
        public String m_fileName;
        // The directory this file is located in
        public String m_directory;

        // The name of the class this Treenode represents
        public String m_className;
        // The parent classes of the Treenode
        public List<String> m_parentClasses;
        // True if this class doesn't inheirit from any other class
        public bool m_isBaseClass;
        
        // The parent of the Treenode in the hierarchy
        public Treenode m_parent;
        // The children of this Treenode
        public List<Treenode> m_children;
    }
}
