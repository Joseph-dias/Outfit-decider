using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandoDress.Forms.Random
{
    public partial class randSettings : Form
    {
        public randSettings()
        {
            InitializeComponent();
        }

        private void randSettings_Load(object sender, EventArgs e)
        {
            foreach(string type in Enum.GetNames(typeof(Code.shirts.shirtType)))
            {
                CheckBox newBX = new CheckBox();
                newBX.Text = type;
                newBX.Name = type;
                checkPNL.Controls.Add(newBX);
            }
        }

        private void goBTN_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                Code.Static_Data.settings.numShirts = Convert.ToInt32(numOUT.Value);
                Code.Static_Data.settings.types = new List<Code.shirts.shirtType>();
                foreach(Control c in checkPNL.Controls)
                {
                    CheckBox b = c as CheckBox;
                    if(b.Checked)
                    {
                        Code.Static_Data.settings.types.Add((Code.shirts.shirtType)Enum.Parse(typeof(Code.shirts.shirtType), b.Text));
                    }
                }
                //Show next form
                randShirts shirtForm = new randShirts();
                Hide();
                shirtForm.ShowDialog();
                Close();
            }
        }

        /// <summary>
        /// Validate this form
        /// </summary>
        /// <returns>Validated or not</returns>
        private bool validate()
        {
            bool oneChecked = false;
            foreach(Control c in checkPNL.Controls)
            {
                if((c as CheckBox).Checked)
                {
                    oneChecked = true;
                    break;
                }
            }
            if (Convert.ToInt32(numOUT.Value) > 0 && oneChecked) return true;
            else return false;
        }
    }
}
