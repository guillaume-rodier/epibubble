using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_WIN_EpiBubble_2017.Classes
{
    class Config
    {
        #region Variables
        private string file;
        #endregion

        #region public Config(string file)
        /// <summary>
        /// It is the constructor of Config
        /// </summary>
        /// <param name="file"></param>
        public Config(string file)
        {
            this.file = getConfigLocation(AppDomain.CurrentDomain.BaseDirectory) + file;
        }
        #endregion

        #region public void WriteFile(string color)
        /// <summary>
        /// This function write in the file of the class
        /// </summary>
        /// <param name="color"></param>
        public void WriteFile(string color)
        {
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(color);
            sw.Close();
        }
        #endregion

        #region public string ReadFile()
        /// <summary>
        /// This function read the file of the class
        /// </summary>
        /// <returns>It returns the first falue</returns>
        public string ReadFile()
        {
            List<string> find = new List<string>();
            StreamReader sr = new StreamReader(file);
            string line = sr.ReadLine();
            while (line != null)
            {
                find.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();

            return find[0];
        }
        #endregion

        # region public List<List<int>> MultiReadFile()
        public List<List<int>> MultiReadFile()
        {
            int count = 0;
            List<List<int>> list = new List<List<int>>();
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(file);

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                String[] subString = line.Split(' ');
                for (int i = 0; i <= subString.Count(); i++)
                {
                    list[count][i] = int.Parse(subString[i]);
                    count++;
                }
            }
            return list;
        }
        #endregion

        #region private string splitLocationDirectory(string value)
        /// <summary>
        /// This function take a location to give the folder where we can find
        /// all the files of the folder of project.
        /// </summary>
        /// <param name="value"></param>
        private string splitLocationDirectory(string value)
        {
            string location = null;
            Char delimiter = '\\';
            String[] substrings = value.Split(delimiter);
            foreach (var substring in substrings)
            {
                if (substring == "bin")
                {
                    break;
                }
                else
                {
                    location += substring + '\\';
                }
            }
            return location;
        }
        #endregion

        #region private string getConfigLocation(string path)
        /// <summary>
        /// This function add to the path in parameter the config path in the content path
        /// </summary>
        /// <param name="value"></param>
        /// <returns>This function returns the path which contains the config of the game</returns>
        private string getConfigLocation(string path)
        {
            string content = splitLocationDirectory(path) + "Content\\Config\\";
            return content;
        }
        #endregion
    }
}
