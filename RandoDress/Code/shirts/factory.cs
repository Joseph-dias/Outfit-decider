using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandoDress.Code.shirts
{
    public enum shirtType { INFORMAL, FORMAL }
    interface IShirtFactory
    {
        bool createShirt(shirtType type, Image pic);
        Task<shirt[]> getShirts(int num, List<shirtType> types);
    }
}
