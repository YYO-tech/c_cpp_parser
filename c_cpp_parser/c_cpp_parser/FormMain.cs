namespace a2l_maker
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void listBoxElfFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


        private void listBoxElfFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                AddAllFiles(file, listBoxElfFile, new string[] { ".elf", ".out", ".abs" });
            }

            Properties.Settings.Default.elf_file_list = string.Join(";", listBoxElfFile.Items.Cast<string>());
            Properties.Settings.Default.Save();
        }

        private void listBoxSourceCodes_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBoxSourceCodes_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                AddAllFiles(file, listBoxSourceCodes, new string[] { ".h", ".cpp", ".c" });
            }

            // Save all items with one string to settings. each item is file path
            Properties.Settings.Default.source_file_list = string.Join(";", listBoxSourceCodes.Items.Cast<string>());
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPrev();
        }

        private void LoadPrev()
        {
            listBoxElfFile.Items.AddRange(Properties.Settings.Default.elf_file_list.Split(';'));
            listBoxSourceCodes.Items.AddRange(Properties.Settings.Default.source_file_list.Split(';'));
        }

        public void AddAllFiles(string path, ListBox listBox, string[] extensions)
        {
            if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
            {
                foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
                {
                    string extension = Path.GetExtension(file);
                    if (extensions.Contains(extension))
                    {
                        // Add the file to the list
                        listBox.Items.Add(file);
                    }
                }
            }
            else
            {
                string extension = Path.GetExtension(path);
                if (extensions.Contains(extension))
                {
                    // Add the file to the list
                    listBox.Items.Add(path);
                }
            }
        }
    }
}