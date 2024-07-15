namespace a2l_maker
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            listBoxSourceCodes = new ListBox();
            listBoxElfFile = new ListBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(530, 447);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listBoxSourceCodes);
            tabPage1.Controls.Add(listBoxElfFile);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(522, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 71);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Source file(s)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "ELF file(s)";
            // 
            // listBoxSourceCodes
            // 
            listBoxSourceCodes.AllowDrop = true;
            listBoxSourceCodes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxSourceCodes.FormattingEnabled = true;
            listBoxSourceCodes.ItemHeight = 15;
            listBoxSourceCodes.Location = new Point(7, 89);
            listBoxSourceCodes.Name = "listBoxSourceCodes";
            listBoxSourceCodes.Size = new Size(509, 319);
            listBoxSourceCodes.TabIndex = 0;
            listBoxSourceCodes.DragDrop += listBoxSourceCodes_DragDrop;
            listBoxSourceCodes.DragEnter += listBoxSourceCodes_DragEnter;
            // 
            // listBoxElfFile
            // 
            listBoxElfFile.AllowDrop = true;
            listBoxElfFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxElfFile.FormattingEnabled = true;
            listBoxElfFile.ItemHeight = 15;
            listBoxElfFile.Location = new Point(7, 21);
            listBoxElfFile.Name = "listBoxElfFile";
            listBoxElfFile.Size = new Size(509, 34);
            listBoxElfFile.TabIndex = 0;
            listBoxElfFile.DragDrop += listBoxElfFile_DragDrop;
            listBoxElfFile.DragEnter += listBoxElfFile_DragEnter;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(308, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private ListBox listBoxSourceCodes;
        private ListBox listBoxElfFile;
        private TabPage tabPage2;
    }
}