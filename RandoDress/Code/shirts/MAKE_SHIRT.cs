using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandoDress.Code.shirts
{
    public class MAKE_SHIRT : factory
    {
        public bool createShirt(shirtType type, Image pic)
        {
            try
            {
                shirt newShirt = new shirt(type, pic);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
