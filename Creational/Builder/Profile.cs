using System;
using System.Collections.Generic;
using System.IO;
using Write;

namespace Builder
{
    class Profile
    {
        private static Print o = new Print();
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
                throw new FileNotFoundException();
            }
        }

        public Profile(string filename)
        {
            if(!LoadProfile(filename))
            {
                throw new FileNotFoundException();
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


        public void PrintProfileCentered()
        {
            // Profile should never be empty or null
            if (fullProfile == null || fullProfile == String.Empty)
            {
                throw new Exception();
            }
            var lines = fullProfile.Split('\n');
            foreach (string line in lines)
            {
                o.Center(line, false);
                o.Line();
            }
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

        public bool AddElement()
        {
            bool selected = false;
            int position = 1;
            
            while (!selected)
            {
                o.Clear();
                PrintProfileCentered();

                Console.WriteLine("\n");
                o.Center("Choose Element Type", false);
                Console.WriteLine("\n\n");

                switch (position)
                { 
                    case 1:
                        o.Left("Picture", true);
                        o.Center("Paragraph", false);
                        o.Right("Title", false);
                        Console.WriteLine("\n");
                        o.Center("Line Break", false);
                        break;
                    case 2:
                        o.Left("Picture", false);
                        o.Center("Paragraph", true);
                        o.Right("Title", false);
                        Console.WriteLine("\n");
                        o.Center("Line Break", false);
                        break;
                    case 3:
                        o.Left("Picture", false);
                        o.Center("Paragraph", false);
                        o.Right("Title", true);
                        Console.WriteLine("\n");
                        o.Center("Line Break", false);
                        break;
                    case 4:
                        o.Left("Picture", false);
                        o.Center("Paragraph", false);
                        o.Right("Title", false);
                        Console.WriteLine("\n");
                        o.Center("Line Break", true);
                        break;
                }

                o.Line();
                ConsoleKeyInfo input = o.Wait();
                switch (input.Key)
                {
                    case (ConsoleKey.RightArrow):
                        if (position < 4)
                        {
                            ++position;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (position > 1)
                        {
                            --position;
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (position)
                        {
                            case 1:
                                AddPicture();
                                selected = true;
                                break;
                            case 2:
                                AddParagraph();
                                selected = true;
                                break;
                            case 3:
                                AddTitle();
                                selected = true;
                                break;
                            case 4:
                                AddLineBreak();
                                selected = true;
                                break;
                        }
                        break;
                }
            }

            return true;
        }

        public void AddPicture()
        { 
            o.Clear();
            PrintProfileCentered();
            o.Line(2);
        }

        public void AddParagraph()
        {
            o.Clear();
            PrintProfileCentered();
            o.Line(2);
            o.Center("Enter Paragraph Text followed by Enter Key:", false);
            o.Line();
            string input = Console.ReadLine();

        }

        public void AddTitle()
        {
            o.Clear();
            PrintProfileCentered();
            o.Line(2);
        }

        public void AddLineBreak()
        {
            o.Clear();
            PrintProfileCentered();
            o.Line(2);
        }

        public void RemoveElement()
        {
            throw new NotImplementedException();
        }

        public bool SaveProfile()
        {
            throw new NotImplementedException();
        }
    }
}
