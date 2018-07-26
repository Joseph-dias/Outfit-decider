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
        public Image myImage { get; private set; }
        public shirtType myType { get; private set; }
        private DateTime? picked; //Date that this shirt was picked
        private int? numWeeks; //Number of weeks to leave the shirt unavailable
        public bool available { get; set; }
        public shirt(shirtType myType, Image pic)
        {
            myImage = pic;
            this.myType = myType;
            picked = null;
            numWeeks = null;
            available = true; //This shirt is available
        }

        /// <summary>
        /// Create shirt class from directory of saved shirt
        /// </summary>
        /// <param name="dir">Shirt directory</param>
        public shirt(DirectoryInfo dir)
        {
            if (!File.Exists(dir.FullName + "\\info.txt") || !File.Exists(dir.FullName + "\\pic.jpg"))
            {
                throw new Exception("Invalid directory");
            }

            //Read from file
            string txt = File.ReadAllText(dir.FullName + "\\info.txt");
            string[] values = txt.Split(';');
            setValues(values);
            myImage = Image.FromFile(dir.FullName + "\\pic.jpg");
        }

        /// <summary>
        /// Set the values of the variables
        /// </summary>
        /// <param name="s">String of values to set</param>
        private void setValues(string[] s)
        {
            if (s.Length < 5) throw new Exception("Not enough values");
            id = Convert.ToInt32(s[0]);
            myType = (shirtType)(Convert.ToInt32(s[1]));
            //The 'picked' date
            if (s[2] == "NULL") picked = null;
            else picked = DateTime.Parse(s[2]);
            //The 'numWeeks' info
            if (s[3] == "NULL") numWeeks = null;
            else numWeeks = Convert.ToInt32(s[3]);
            available = bool.Parse(s[4]);
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
            //Save text values
            FileStream s = File.Create(newDir.FullName + "\\info.txt");
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes((id + ";" + Convert.ToInt32(myType) + ";" + (picked == null ? "NULL" : picked.Value.Month + "/" + picked.Value.Day + "/" + picked.Value.Year) + ";" + (numWeeks == null ? "NULL" : numWeeks.Value.ToString()) + ";" + available.ToString()).ToCharArray());
            s.Write(buffer, 0, buffer.Count());
            s.Close(); //Close the stream
            //Save image
            myImage.Save(newDir.FullName + "\\pic.jpg");
        }
    }
}
