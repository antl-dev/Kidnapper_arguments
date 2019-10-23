using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TKA
{
    public partial class Form1 : Form
    {
        string[] args;
        public Form1(string[] args)
        {
            this.args = args;
            InitializeComponent();

            try
            {
                if (args.Length > 0)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        richTextBox.Text += String.Format("Argument#{0}: {1} \r\n", i + 1, args[i]);
                    }
                }
                else
                {
                    MessageBox.Show("The arguments are not passed!",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    Process.GetCurrentProcess().Kill();
                }
            }

            catch
            {
                MessageBox.Show("Contact the developer",
                "Critical error!!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); 
                Process.GetCurrentProcess().Kill();
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/antl-dev/The-kidnapper-arguments");
        }
    }
}