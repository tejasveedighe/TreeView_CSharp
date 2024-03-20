using System.Security;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                TreeNode node = new TreeNode(NodeTxtBox.Text);
                treeView1.Nodes.Add(node);
            }

        }

        private void textBox1_Validation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NodeTxtBox.Text))
            {
                e.Cancel = true;
                NodeTxtBox.Focus();
                errorProvider1.SetError(NodeTxtBox, "Name should not be empty");
                //notifyIcon1.Text = "Text cannot be null";
                //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                //notifyIcon1.BalloonTipText = "Text Cannot be null";
                //notifyIcon1.BalloonTipTitle = "Information";
                //notifyIcon1.ShowBalloonTip(1000);
                //notifyIcon1.Visible = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(NodeTxtBox, "");
            }
        }

        private void AddChildNodeBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                TreeNode treeNode = new TreeNode(ChildNodeTxtBox.Text);
                treeView1.SelectedNode.Nodes.Add(treeNode);
            }
        }

        private void RemoveNodeBtn_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}
