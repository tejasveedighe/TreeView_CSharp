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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 83);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(192, 169);
            treeView1.TabIndex = 0;
            // 
            // NodeTxtBox
            // 
            NodeTxtBox.Location = new Point(269, 101);
            NodeTxtBox.Name = "NodeTxtBox";
            NodeTxtBox.Size = new Size(185, 23);
            NodeTxtBox.TabIndex = 1;
            NodeTxtBox.Validating += textBox1_Validation;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 83);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Node Label";
            // 
            // button1
            // 
            button1.Location = new Point(269, 130);
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
            ChildNodeTxtBox.Location = new Point(269, 205);
            ChildNodeTxtBox.Name = "ChildNodeTxtBox";
            ChildNodeTxtBox.Size = new Size(185, 23);
            ChildNodeTxtBox.TabIndex = 4;
            ChildNodeTxtBox.Validating += textBox1_Validation;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 187);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Child Node";
            // 
            // AddChildNodeBtn
            // 
            AddChildNodeBtn.Location = new Point(269, 234);
            AddChildNodeBtn.Name = "AddChildNodeBtn";
            AddChildNodeBtn.Size = new Size(75, 23);
            AddChildNodeBtn.TabIndex = 6;
            AddChildNodeBtn.Text = "Add Child Node";
            AddChildNodeBtn.UseVisualStyleBackColor = true;
            AddChildNodeBtn.Click += AddChildNodeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 450);
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
    }
}
