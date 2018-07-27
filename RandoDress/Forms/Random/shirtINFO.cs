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
    public partial class shirtINFO : Form
    {
        private Code.shirts.shirt thisShirt;
        public shirtINFO()
        {
            InitializeComponent();
        }

        private void shirtINFO_Load(object sender, EventArgs e)
        {
            thisShirt = Code.Static_Data.shirtData.selectedShirt;
            Code.Static_Data.shirtData.selectedShirt = null;
            pic.Image = thisShirt.myImage;
            typeTXT.Text = thisShirt.myType.ToString();
            availabilityUI();
        }

        /// <summary>
        /// Decide what to display based on availability of the shirt
        /// </summary>
        private void availabilityUI()
        {
            if(thisShirt.available) //The shirt is available
            {
                if (!availableTXT.Visible) availableTXT.Visible = true;
                if (usedTXT.Visible) usedTXT.Visible = false;
                if (mAvailableBTN.Visible) mAvailableBTN.Visible = false;
                if (!usedBTN.Visible) usedBTN.Visible = true;
            }else //The shirt is not available
            {
                if (availableTXT.Visible) availableTXT.Visible = false;
                if (!usedTXT.Visible) usedTXT.Visible = true;
                if (!mAvailableBTN.Visible) mAvailableBTN.Visible = true; ;
                if (usedBTN.Visible) usedBTN.Visible = false;
            }
        }

        private void shirtINFO_MouseLeave(object sender, EventArgs e)
        {
            bool xBound = false, yBound = false;
            Point mousePos = MousePosition;
            Point topLeft = Location;
            Point bottomRight = new Point(topLeft.X + Width, topLeft.Y + Height);
            if (topLeft.X < mousePos.X && bottomRight.X > mousePos.X) xBound = true;
            if (topLeft.Y < mousePos.Y && bottomRight.Y > mousePos.Y) yBound = true;
            if (!(xBound && yBound))
            {
                DialogResult = DialogResult.Ignore;
                Close();
            }
        }

        private void usedBTN_Click(object sender, EventArgs e)
        {
            weeksPNL.Visible = true;
            availabilityUI();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weekNUM.Value = 0;
            weeksPNL.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(weekNUM.Value) > 0)
            {
                thisShirt.useShirt(Convert.ToInt32(weekNUM.Value), delBX.Checked);
                weekNUM.Value = 0;
                weeksPNL.Visible = false;
                availabilityUI();
            }
        }

        private void mAvailableBTN_Click(object sender, EventArgs e)
        {
            if(!thisShirt.resetShirt())
            {
                DialogResult result = MessageBox.Show("This shirt is scheduled to be deleted.\nAre you sure?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Code.shirts.shirtManager.getShirts.deleteShirt(thisShirt);
                    DialogResult = DialogResult.Abort;
                    Close();
                }
                else thisShirt.abortDelete();
            }
            availabilityUI();
        }
    }
}
