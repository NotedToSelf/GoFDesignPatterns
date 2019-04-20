using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Builder
{
    class Profile
    {
        private const int width = 100;
        private const int height = 200;
        private string fullProfile;
        private List<Element> profileElements;

        /// <summary>
        /// Default Constructor.
        /// Creates Default profile from BlankProfile.txt
        /// </summary>
        public Profile()
        {
            if (!LoadProfile("BlankProfile.txt"))
            {
                //generate new blank profile with correct dimensions
                throw new Exception();
            }
        }
        /// <summary>
        /// Prints the current profile to the console
        /// </summary>
        public void PrintProfile()
        {
            // Profile should never be empty or null
            if (fullProfile == null || fullProfile == String.Empty)
            {
                throw new Exception();
            }

            Console.Write(fullProfile);
        }

        /// <summary>
        /// Takes the list of Elements and renders 
        /// </summary>
        /// <returns>
        /// True:   Profile successfully rendered and saved
        /// False:  Error in rendering. Profile discarded
        /// </returns>
        public bool RenderProfile()
        {
            return false;
        }

        /// <summary>
        /// Loads a previouly saved profile
        /// </summary>
        /// <returns>
        /// True:   Profile Successfully Loaded
        /// False:  Error Loading Profile
        /// </returns>
        public bool LoadProfile(string filename)
        {
            fullProfile = File.ReadAllText(filename);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>

    }
}
