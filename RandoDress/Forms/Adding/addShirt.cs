using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandoDress.Forms.Adding
{
    public partial class addShirt : Form
    {
        private static bool picAdded;
        private Code.shirts.factory makeShirt;
        private int checkedIndex;
        public addShirt()
        {
            InitializeComponent();
            picAdded = false;
            makeShirt = new Code.shirts.MAKE_SHIRT();
        }

        private void picBX_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.DefaultExt = ".jpg";
            dialog.Title = "Select Picture";
            dialog.Filter = "Picture Files (*.jpg)|*.jpg";
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                Image pic = Image.FromFile(dialog.FileName);
                picBX.Image = pic;
                picInfoLBL.Visible = false;
                picAdded = true;
            }
        }

        private void addShirt_Load(object sender, EventArgs e)
        {
            int x = 0;
            checkedIndex = 0;
            foreach(Enum val in Enum.GetValues(typeof(Code.shirts.shirtType)))
            {
                checkBX.Items.Add(val.ToString(), x == 0);
                x++;
            }
        }

        private void checkBX_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkedIndex = e.Index;
            for(int x = 0; x < checkBX.Items.Count; x++)
            {
                if (x != e.Index) checkBX.SetItemChecked(x, false);
            }
        }

        private bool validate()
        {
            if (checkBX.CheckedItems.Count == 1 && picAdded) return true;
            else return false;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                if (makeShirt.createShirt((Code.shirts.shirtType)checkedIndex, picBX.Image))
                {
                    MessageBox.Show("SAVED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }else
                {
                    MessageBox.Show("Whoops, something went wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                DialogResult result = MessageBox.Show("Invalid info", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel) Close();
            }
        }
    }
}
