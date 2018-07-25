using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandoDress.Code.shirts
{
    /// <summary>
    /// Manages the list of shirts
    /// </summary>
    class shirtManager
    {
        private static shirtManager instance = null;
        private DirectoryInfo dir;
        List<shirt> myList;
        private int topID;
        private shirtManager()
        {
            topID = 0;
            myList = new List<shirt>();
            if (!Directory.Exists(Environment.SpecialFolder.MyDocuments.ToString() + "\\myrandoshirts (DO NOT DELETE)")) Directory.CreateDirectory(Environment.SpecialFolder.MyDocuments.ToString() + "\\myrandoshirts (DO NOT DELETE)");
            dir = new DirectoryInfo(Environment.SpecialFolder.MyDocuments.ToString() + "\\myrandoshirts (DO NOT DELETE)");
        }
        /// <summary>
        /// Get the instance of this singleton
        /// </summary>
        public static shirtManager getShirts
        {
            get
            {
                if (instance == null) instance = new shirtManager();
                return instance;
            }
        }

        /// <summary>
        /// Add a shirt to the list
        /// </summary>
        /// <param name="newShirt">Shirt to add</param>
        public void addShirt(shirt newShirt)
        {
            newShirt.id = topID++;
            myList.Add(newShirt);
            newShirt.save(dir);
        }
    }
}
