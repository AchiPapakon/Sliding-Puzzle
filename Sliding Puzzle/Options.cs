using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sliding_Puzzle
{
    public partial class frmOptions : Form
    {
        private int backboardSize;
        private List<RadioButton> radioButtonList = new List<RadioButton>();
        public int newSize { get; set; }

        public frmOptions(int in_backboardSize) : this()
        {
            this.backboardSize = in_backboardSize;

            // getElementById:
            string elementName = "radio" + backboardSize;
            (this.Controls.Find(elementName, true).FirstOrDefault() as RadioButton).Checked = true;
        }

        public frmOptions()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                string elementName = "radio" + (i + 2);
                radioButtonList.Add(this.Controls.Find(elementName, true).FirstOrDefault() as RadioButton);
            }
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

        }

        private void frmOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            int pos = 2;
            foreach (var radioButton in radioButtonList)
            {
                if (radioButton.Checked)
                {
                    this.newSize = pos;
                    break;
                }
                pos++;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
