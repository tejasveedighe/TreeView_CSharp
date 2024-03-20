namespace Views
{
    partial class List_View
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
            fistName = new ColumnHeader();
            lastName = new ColumnHeader();
            DOB = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { fistName, lastName, DOB });
            listView1.GridLines = true;
            listView1.Location = new Point(12, 37);
            listView1.Name = "listView1";
            listView1.Size = new Size(550, 382);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // fistName
            // 
            fistName.Text = "First Name";
            fistName.Width = 150;
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            lastName.Width = 150;
            // 
            // DOB
            // 
            DOB.Text = "DOB";
            DOB.Width = 90;
            // 
            // List_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(listView1);
            Name = "List_View";
            Text = "List View";
            Load += List_View_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader fistName;
        private ColumnHeader lastName;
        private ColumnHeader DOB;
    }
}