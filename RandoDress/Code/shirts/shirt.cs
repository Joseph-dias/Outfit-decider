using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandoDress.Code.shirts
{
    public class shirt
    {
        /// <summary>
        /// This shirt's id #
        /// </summary>
        public int id { get; set; }
        private Image myImage;
        private shirtType myType;
        private DateTime? picked; //Date that this shirt was picked
        private int? numWeeks; //Number of weeks to leave the shirt unavailable
        private bool available;
        public shirt(shirtType myType, Image pic)
        {
            myImage = pic;
            this.myType = myType;
            picked = null;
            numWeeks = null;
            available = true; //This shirt is available
        }

        /// <summary>
        /// Save the shirt
        /// </summary>
        /// <param name="dir">Current top directory for the program</param>
        public void save(DirectoryInfo dir)
        {
            DirectoryInfo newDir;
            if (!Directory.Exists(dir.FullName + "\\" + id + "shirt")) newDir = dir.CreateSubdirectory(id + "shirt");
            else newDir = new DirectoryInfo(dir.FullName + "\\" + id + "shirt");
            FileStream s = File.Create(newDir.FullName + "\\info.txt");
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes((id + ";" + myType.ToString() + ";" + picked.ToString() + ";" + numWeeks.ToString() + ";" + available.ToString()).ToCharArray());
            s.Write(buffer, 0, buffer.Count());
            s.Close(); //Close the stream
        }
    }
}
