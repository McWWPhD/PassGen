using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        PassGen pass = new PassGen();

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void butGenerate_Click(object sender, EventArgs e)
        {
            if (rbOnlyNumbers.Checked)
            {
                for (int i = 0; i < numQuantity.Value; i++)
                {
                    lbList.Items.Add(pass.GenNum((int)numLength.Value));

                }
            }

            else if (rbNumAndLett.Checked)
            {
                for (int i = 0; i < numQuantity.Value; i++)
                {
                    lbList.Items.Add(pass.GenNumLett((int)numLength.Value));
                }
            }


            else if (rbNumLettSpec.Checked)
            {
                for (int i = 0; i < numQuantity.Value; i++)
                {
                    lbList.Items.Add(pass.GenNumLettSpec((int)numLength.Value));

                }
            }




        }

        private void copyPass(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(lbList.SelectedItem.ToString());
            MessageBox.Show(string.Format("Hasło przekopiowano do schowka", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }
    }

}
