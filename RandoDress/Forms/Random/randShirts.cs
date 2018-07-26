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
    public partial class randShirts : Form
    {
        private Code.shirts.IShirtFactory factory;
        private Code.shirts.shirt[] returned;
        public randShirts()
        {
            InitializeComponent();
        }

        private void randShirts_Load(object sender, EventArgs e)
        {
            factory = new Code.shirts.MAKE_SHIRT();
            try
            {
                returned = factory.getShirts(Code.Static_Data.settings.numShirts, Code.Static_Data.settings.types);
                if (returned.Count() == 0) warningLBL.Visible = true;
                foreach (Code.shirts.shirt s in returned)
                {
                    imageDisp.Images.Add(s.myImage);
                }
                for(int x = 0; x < imageDisp.Images.Count; x++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = x;
                    listView1.Items.Add(item);
                }
            }catch(Exception)
            {
                warningLBL.Visible = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Code.shirts.shirt myShirt = returned[listView1.SelectedItems[0].ImageIndex];
                Code.Static_Data.shirtData.selectedShirt = myShirt;
                shirtINFO selected = new shirtINFO();
                selected.ShowDialog();
            }
            else MessageBox.Show("SELECT ONE ITEM", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
