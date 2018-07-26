using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandoDress.Code
{
    public abstract class Clothing
    {
        /// <summary>
        /// The parent directory
        /// </summary>
        protected DirectoryInfo myDir;

        /// <summary>
        /// Save this piece of clothing
        /// </summary>
        /// <param name="dir">Current top directory for the program</param>
        public abstract void save(DirectoryInfo dir);
    }
}
