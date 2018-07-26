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
        private static Random rand = null;
        private DirectoryInfo dir;
        private List<shirt> myList;
        private int topID;
        private shirtManager()
        {
            if (rand == null) rand = new Random();
            topID = 0;
            myList = new List<shirt>();
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\myrandoshirts (DO NOT DELETE)")) Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\myrandoshirts (DO NOT DELETE)");
            dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\myrandoshirts (DO NOT DELETE)");
            loadShirts();
        }

        private void loadShirts()
        {
            int top = -1;
            foreach(DirectoryInfo info in dir.GetDirectories())
            {
                if (info.Name.Contains("shirt"))
                {
                    try
                    {
                        shirt newShirt = new shirt(info);
                        myList.Add(newShirt);
                        int toCompare = Convert.ToInt32(info.Name.TrimEnd('s', 'h', 'i', 'r', 't'));
                        if (top < toCompare) top = toCompare;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            if(topID >= 0) topID = top + 1;
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

        /// <summary>
        /// Return a random selection of shirts
        /// </summary>
        /// <param name="num">Number of shirts to return</param>
        /// <param name="TYPES_TO_SELECT">Types of shirts to select from</param>
        /// <returns>Collection of random shirts</returns>
        public shirt[] getRandShirts(int num, List<shirtType> TYPES_TO_SELECT)
        {
            if (myList.Count == 0) throw new Exception("INVALID NUMBER OF ELEMENTS");
            else if (num > myList.Count) num = myList.Count;
            List<int> selectedIDs = new List<int>();
            shirt[] toReturn = new shirt[num];
            for(int x = 0; x < num; x++)
            {
                bool chosen = false;
                do
                {
                    int randNum = rand.Next(0, myList.Count);
                    shirt selected = myList[randNum];
                    if(!selectedIDs.Contains(selected.id) && selected.available && TYPES_TO_SELECT.Contains(selected.myType)) //If it hasn't already been selected, it's available, and it's of the correct type
                    {
                        selectedIDs.Add(selected.id);
                        toReturn[x] = selected;
                        chosen = true;
                    }
                } while (!chosen);
            }
            return toReturn;
        }
    }
}
