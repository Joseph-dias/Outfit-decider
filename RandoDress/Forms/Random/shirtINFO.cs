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
        }
    }
}
