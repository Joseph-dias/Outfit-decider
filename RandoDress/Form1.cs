using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandoDress
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void hoverPlus_MouseEnter(object sender, EventArgs e)
        {
        }

        private void hoverPlus_MouseLeave(object sender, EventArgs e)
        {
            if (hoverPlus.Visible) hoverPlus.Visible = false;
        }

        private void whitePlus_MouseEnter(object sender, EventArgs e)
        {
            if (!hoverPlus.Visible) hoverPlus.Visible = true; //Show that the user is hovering over the "button"
        }

        private void infinityPIC_MouseEnter(object sender, EventArgs e)
        {
            if (!infinityPICHOV.Visible) infinityPICHOV.Visible = true;
        }

        private void infinityPICHOV_MouseLeave(object sender, EventArgs e)
        {
            if (infinityPICHOV.Visible) infinityPICHOV.Visible = false;
        }
    }
}
