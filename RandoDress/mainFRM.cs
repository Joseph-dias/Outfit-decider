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

        private void hoverPlus_Click(object sender, EventArgs e)
        {
            Forms.Adding.addShirt shirtAdded = new Forms.Adding.addShirt();
            Hide();
            shirtAdded.ShowDialog();
            Show();
        }

        private void infinityPICHOV_Click(object sender, EventArgs e)
        {
            Forms.Random.randSettings settings = new Forms.Random.randSettings();
            Hide();
            DialogResult result = settings.ShowDialog();
            if (result == DialogResult.Cancel) Show();
            else Close();
        }
    }
}
