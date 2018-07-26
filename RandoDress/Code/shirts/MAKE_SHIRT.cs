using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandoDress.Code.shirts
{
    public class MAKE_SHIRT : IShirtFactory
    {
        public bool createShirt(shirtType type, Image pic)
        {
            try
            {
                shirt newShirt = new shirt(type, pic);
                shirtManager.getShirts.addShirt(newShirt);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public shirt[] getShirts(int num, List<shirtType> types)
        {
            return shirtManager.getShirts.getRandShirts(num, types);
        }
    }
}
