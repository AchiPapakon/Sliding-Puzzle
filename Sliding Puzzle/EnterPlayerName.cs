using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sliding_Puzzle
{
    public partial class frmEnterPlayerName : Form
    {
        private string playerName;

        public string GetPlayerName()
        {
            return playerName;
        }

        public frmEnterPlayerName()
        {
            InitializeComponent();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            Match m = Regex.Match(txtPlayerName.Text, @"^\w+");
            string matchedText = m.Value;
            if (matchedText != txtPlayerName.Text)
            {
                MessageBox.Show("Please only use valid characters");

                // Remove the invalid characters (if more than one via copy-paste):
                txtPlayerName.Text = m.Value;
                //txtPlayerName.Text = txtPlayerName.Text.Remove(txtPlayerName.Text.Length - 1);
                txtPlayerName.SelectionStart = txtPlayerName.TextLength;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                MessageBox.Show("Please enter a proper name");
                txtPlayerName.Text = "";
            }
            else
            {
                playerName = txtPlayerName.Text;
                this.Close(); 
            }
        }
    }
}
