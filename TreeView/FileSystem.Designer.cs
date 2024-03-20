namespace Views
{
    partial class FileSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            fileName = new ColumnHeader();
            filePath = new ColumnHeader();
            Open_Btn = new Button();
            FileName_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            FilePath_txt = new TextBox();
            AddBtn = new Button();
            Remove_Btn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { fileName, filePath });
            listView1.GridLines = true;
            listView1.Location = new Point(12, 101);
            listView1.Name = "listView1";
            listView1.Size = new Size(567, 307);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // fileName
            // 
            fileName.Text = "File name";
            // 
            // filePath
            // 
            filePath.Text = "File Path";
            // 
            // Open_Btn
            // 
            Open_Btn.Location = new Point(504, 415);
            Open_Btn.Name = "Open_Btn";
            Open_Btn.Size = new Size(75, 23);
            Open_Btn.TabIndex = 1;
            Open_Btn.Text = "Open";
            Open_Btn.UseVisualStyleBackColor = true;
            Open_Btn.Click += Open_Btn_Click;
            // 
            // FileName_txt
            // 
            FileName_txt.Location = new Point(84, 12);
            FileName_txt.Name = "FileName_txt";
            FileName_txt.Size = new Size(153, 23);
            FileName_txt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 53);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "File Path";
            // 
            // FilePath_txt
            // 
            FilePath_txt.Location = new Point(84, 50);
            FilePath_txt.Name = "FilePath_txt";
            FilePath_txt.Size = new Size(153, 23);
            FilePath_txt.TabIndex = 5;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(253, 50);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Remove_Btn
            // 
            Remove_Btn.Location = new Point(12, 415);
            Remove_Btn.Name = "Remove_Btn";
            Remove_Btn.Size = new Size(75, 23);
            Remove_Btn.TabIndex = 7;
            Remove_Btn.Text = "Remove";
            Remove_Btn.UseVisualStyleBackColor = true;
            Remove_Btn.Click += Remove_Btn_Click;
            // 
            // FileSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 450);
            Controls.Add(Remove_Btn);
            Controls.Add(AddBtn);
            Controls.Add(FilePath_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FileName_txt);
            Controls.Add(Open_Btn);
            Controls.Add(listView1);
            Name = "FileSystem";
            Text = "FileSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader fileName;
        private ColumnHeader filePath;
        private Button Open_Btn;
        private TextBox FileName_txt;
        private Label label1;
        private Label label2;
        private TextBox FilePath_txt;
        private Button AddBtn;
        private Button Remove_Btn;
    }
}