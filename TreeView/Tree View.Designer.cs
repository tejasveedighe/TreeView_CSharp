namespace TreeView
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            treeView1 = new System.Windows.Forms.TreeView();
            NodeTxtBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            errorProvider1 = new ErrorProvider(components);
            ChildNodeTxtBox = new TextBox();
            label2 = new Label();
            AddChildNodeBtn = new Button();
            RemoveNodeBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EditSelectedNodeTxtBox = new TextBox();
            button2 = new Button();
            ExpandAllBtn = new Button();
            CollapseAllBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 83);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(192, 287);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // NodeTxtBox
            // 
            NodeTxtBox.Location = new Point(256, 83);
            NodeTxtBox.Name = "NodeTxtBox";
            NodeTxtBox.Size = new Size(185, 23);
            NodeTxtBox.TabIndex = 1;
            NodeTxtBox.Validating += textBox1_Validation;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 65);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Node Label";
            // 
            // button1
            // 
            button1.Location = new Point(256, 112);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ChildNodeTxtBox
            // 
            ChildNodeTxtBox.Location = new Point(256, 167);
            ChildNodeTxtBox.Name = "ChildNodeTxtBox";
            ChildNodeTxtBox.Size = new Size(185, 23);
            ChildNodeTxtBox.TabIndex = 4;
            ChildNodeTxtBox.Validating += textBox1_Validation;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 149);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Child Node";
            // 
            // AddChildNodeBtn
            // 
            AddChildNodeBtn.Location = new Point(256, 196);
            AddChildNodeBtn.Name = "AddChildNodeBtn";
            AddChildNodeBtn.Size = new Size(75, 23);
            AddChildNodeBtn.TabIndex = 6;
            AddChildNodeBtn.Text = "Add Child Node";
            AddChildNodeBtn.UseVisualStyleBackColor = true;
            AddChildNodeBtn.Click += AddChildNodeBtn_Click;
            // 
            // RemoveNodeBtn
            // 
            RemoveNodeBtn.Location = new Point(51, 376);
            RemoveNodeBtn.Name = "RemoveNodeBtn";
            RemoveNodeBtn.Size = new Size(106, 23);
            RemoveNodeBtn.TabIndex = 7;
            RemoveNodeBtn.Text = "Remove Node";
            RemoveNodeBtn.UseVisualStyleBackColor = true;
            RemoveNodeBtn.Click += RemoveNodeBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 9);
            label3.Name = "label3";
            label3.Size = new Size(218, 30);
            label3.TabIndex = 8;
            label3.Text = "Welcome to Tree View";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 63);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Tree View";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 239);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 10;
            label5.Text = "Edit Selected Node";
            // 
            // EditSelectedNodeTxtBox
            // 
            EditSelectedNodeTxtBox.Location = new Point(256, 257);
            EditSelectedNodeTxtBox.Name = "EditSelectedNodeTxtBox";
            EditSelectedNodeTxtBox.Size = new Size(185, 23);
            EditSelectedNodeTxtBox.TabIndex = 11;
            EditSelectedNodeTxtBox.Validating += textBox1_Validation;
            // 
            // button2
            // 
            button2.Location = new Point(256, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Edit Node";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ExpandAllBtn
            // 
            ExpandAllBtn.Location = new Point(260, 336);
            ExpandAllBtn.Name = "ExpandAllBtn";
            ExpandAllBtn.Size = new Size(75, 23);
            ExpandAllBtn.TabIndex = 13;
            ExpandAllBtn.Text = "Expand All";
            ExpandAllBtn.UseVisualStyleBackColor = true;
            ExpandAllBtn.Click += ExpandAllBtn_Click;
            // 
            // CollapseAllBtn
            // 
            CollapseAllBtn.Location = new Point(359, 336);
            CollapseAllBtn.Name = "CollapseAllBtn";
            CollapseAllBtn.Size = new Size(82, 23);
            CollapseAllBtn.TabIndex = 14;
            CollapseAllBtn.Text = "Collapse All";
            CollapseAllBtn.UseVisualStyleBackColor = true;
            CollapseAllBtn.Click += CollapseAllBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 411);
            Controls.Add(CollapseAllBtn);
            Controls.Add(ExpandAllBtn);
            Controls.Add(button2);
            Controls.Add(EditSelectedNodeTxtBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RemoveNodeBtn);
            Controls.Add(AddChildNodeBtn);
            Controls.Add(label2);
            Controls.Add(ChildNodeTxtBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(NodeTxtBox);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private TextBox NodeTxtBox;
        private Label label1;
        private Button button1;
        private NotifyIcon notifyIcon1;
        private ErrorProvider errorProvider1;
        private Button AddChildNodeBtn;
        private Label label2;
        private TextBox ChildNodeTxtBox;
        private Button RemoveNodeBtn;
        private Label label3;
        private Label label4;
        private Button button2;
        private TextBox EditSelectedNodeTxtBox;
        private Label label5;
        private Button CollapseAllBtn;
        private Button ExpandAllBtn;
    }
}
