using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CSE445_Project3_Assignment5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //This service takes in a string and removes any stop words.
        //This includes “a”, “an”, “in”, “on”, “the”, “is”, “are”, “am”.
        //Also filers out XML element tags
        public string WordFilter(string s)
        {
            //1st take the input string and break it into one word strings
            string[] words = s.Split(' ');

            //Now iterate thrught the words[] and set any string that equals 
            //a stop word to "".
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x] == "a" || words[x] == "an" ||
                   words[x] == "in" || words[x] == "on" ||
                   words[x] == "the" || words[x] == "is" ||
                   words[x] == "am" || words[x] == "and" ||
                   words[x] == "it" || words[x] == "for" ||
                   words[x] == "or" || words[x] == "but" ||
                   words[x] == "my" || words[x] == "your" ||
                   words[x] == "our" || words[x] == "their" ||
                   words[x] == "A" || words[x] == "An" || 
                   words[x] == "In" || words[x] == "On" ||
                   words[x] == "The" ||words[x] == "Is" || 
                   words[x] == "Am" || words[x] == "And" ||
                   words[x] == "It" || words[x] == "For" ||
                   words[x] == "Or" || words[x] == "But" ||
                   words[x] == "My" || words[x] == "Your" ||
                   words[x] == "Our" || words[x] == "Their")
                {
                    words[x] = "";
                }
            }

            //Now go through and remove any XML tags that are included 
            for (int x = 0; x < words.Length; x++)
            {
                string temp = words[x];

                for (int i = 0; i < temp.Length; i++)//used to parse temp and count the number of characters before the 1st "<" is found
                {
                    if (temp[i].ToString() == "<") //look for the start of a XML tag
                    {
                        for (int y = i + 1; y < temp.Length; y++) //start a index to search for the the end of a tag
                        {
                            if (temp[y].ToString() == ">") //if the tag end is found
                            {

                                if (temp[0].ToString() == "<") //do this if nothing comes before the "<"
                                {
                                    //delete the tag from the word
                                    y++;
                                    words[x] = temp.Remove(i, y);
                                }
                                else //do this if there are chars before the "<"
                                {
                                    words[x] = temp.Remove(i);
                                }
                            }
                        }
                    }
                }
            }

            //Now combine the words[] into a single array to be returned
            string filteredString = "";
            for (int x = 0; x < words.Length; x++)
            {
                if (filteredString == "") //run this if the filteredString is empty
                {
                    if (words[x] != "")
                    {
                        filteredString = filteredString + words[x];
                    }
                }
                else if (words[x] != "") //run this if the filteredString is not empty
                {
                    filteredString = filteredString + " " + words[x];
                }
            }

            return filteredString;
        }

        public string Stemming(string s)
        {
            //Analyze a string containing words and replace each of the inflected or derived words to their stem or root word.

            //1st break the string into an array of strings (1 word per element)
            string[] words = s.Split(' ');

            //Go through each word and remove prefixes and suffixes
            for (int x = 0; x < words.Length; x++)
            {
                //determine the length of the word
                int wordLength = words[x].Length;

                //Prefixes
                //un
                if (wordLength >= 2)
                {
                    if (words[x].Substring(0, 2) == "un" || words[x].Substring(0, 2) == "Un")
                    {
                        words[x] = words[x].Remove(0, 2);
                        wordLength = wordLength - 2;
                    }
                }

                //de
                if (wordLength >= 2)
                {
                    if (words[x].Substring(0, 2) == "de" || words[x].Substring(0, 2) == "De")
                    {
                        words[x] = words[x].Remove(0, 2);
                        wordLength = wordLength - 2;
                    }
                }

                //mis
                if (wordLength >= 3)
                {
                    if (words[x].Substring(0, 3) == "mis" || words[x].Substring(0, 3) == "Mis")
                    {
                        if (words[x] != "Miss" && words[x] != "miss")
                        {
                            words[x] = words[x].Remove(0, 3);
                            wordLength = wordLength - 3;
                        }
                    }
                }

                //dis
                if (wordLength >= 3)
                {
                    if (words[x].Substring(0, 3) == "dis" || words[x].Substring(0, 3) == "Dis")
                    {
                        words[x] = words[x].Remove(0, 3);
                        wordLength = wordLength - 3;
                    }
                }

                //out
                if (wordLength >= 3)
                {
                    if (words[x].Substring(0, 3) == "out" || words[x].Substring(0, 3) == "Out")
                    {
                        if (words[x] != "out" && words[x] != "Out")
                        {
                            words[x] = words[x].Remove(0, 3);
                            wordLength = wordLength - 3;
                        }
                    }
                }

                //re
                if (wordLength >= 2)
                {
                    if (words[x].Substring(0, 2) == "re" || words[x].Substring(0, 2) == "Re")
                    {
                        words[x] = words[x].Remove(0, 2);
                        wordLength = wordLength - 2;
                    }
                }

                //be
                if (wordLength >= 2)
                {
                    if (words[x].Substring(0, 2) == "be" || words[x].Substring(0, 2) == "Be")
                    {
                        if (words[x] != "be" && words[x] != "Be")
                        {
                            words[x] = words[x].Remove(0, 2);
                            wordLength = wordLength - 2;
                        }
                    }
                }

                //over
                if (wordLength >= 5)
                {
                    if (words[x].Substring(0, 4) == "over" || words[x].Substring(0, 4) == "Over")
                    {
                        words[x] = words[x].Remove(0, 4);
                        wordLength = wordLength - 4;
                    }
                }

                //fore
                if (wordLength >= 4)
                {
                    if (words[x].Substring(0, 4) == "fore" || words[x].Substring(0, 4) == "Fore")
                    {
                        words[x] = words[x].Remove(0, 4);
                        wordLength = wordLength - 4;
                    }
                }

                //under
                if (wordLength >= 6)
                {
                    if (words[x].Substring(0, 5) == "under" || words[x].Substring(0, 5) == "Under")
                    {
                        words[x] = words[x].Remove(0, 5);
                        wordLength = wordLength - 5;
                    }
                }

                //Suffixes
                //ful
                if (wordLength >= 4)
                {
                    if (words[x].Substring(words[x].Length - 4) == "ful." ||
                        words[x].Substring(words[x].Length - 4) == "ful?" ||
                        words[x].Substring(words[x].Length - 4) == "ful!" ||
                        words[x].Substring(words[x].Length - 4) == "ful,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 4, 3);
                        wordLength = wordLength - 2;
                    }
                }

                if (wordLength >= 3)
                {
                    if (words[x].Substring(words[x].Length - 3) == "ful")
                    {
                        words[x] = words[x].Remove(words[x].Length - 3);
                        wordLength = wordLength - 3;
                    }
                }

                //al
                if (wordLength >= 3)
                {
                    if (words[x].Substring(words[x].Length - 3) == "al." ||
                        words[x].Substring(words[x].Length - 3) == "al?" ||
                        words[x].Substring(words[x].Length - 3) == "al!" ||
                        words[x].Substring(words[x].Length - 3) == "al,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 3, 2);
                        wordLength = wordLength - 2;
                    }
                }
                if (wordLength >= 2)
                {
                    if (words[x].Substring(words[x].Length - 2) == "al")
                    {
                        if (words[x] != "all" && words[x] != "All")
                        {
                            words[x] = words[x].Remove(words[x].Length - 2);
                            wordLength = wordLength - 2;
                        }
                    }
                }

                //ed
                if (wordLength >= 3)
                {
                    if (words[x].Substring(words[x].Length - 3) == "ed." ||
                        words[x].Substring(words[x].Length - 3) == "ed?" ||
                        words[x].Substring(words[x].Length - 3) == "ed!" ||
                        words[x].Substring(words[x].Length - 3) == "ed,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 3, 2);
                        wordLength = wordLength - 2;
                    }
                }
                if (wordLength >= 2)
                {
                    if (words[x].Substring(words[x].Length - 2) == "ed")
                    {
                        words[x] = words[x].Remove(words[x].Length - 2);
                        wordLength = wordLength - 2;

                    }
                }

                //less
                if (wordLength >= 6)
                {
                    if (words[x].Substring(words[x].Length - 5) == "less." ||
                        words[x].Substring(words[x].Length - 5) == "less?" ||
                        words[x].Substring(words[x].Length - 5) == "less!" ||
                        words[x].Substring(words[x].Length - 5) == "less,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 5, 4);
                        wordLength = wordLength - 4;
                    }
                }
                if (wordLength >= 5)
                {
                    if (words[x].Substring(words[x].Length - 4) == "less")
                    {
                        words[x] = words[x].Remove(words[x].Length - 4);
                        wordLength = wordLength - 4;
                    }
                }

                //er
                if (wordLength >= 3)
                {
                    if (words[x].Substring(words[x].Length - 3) == "er." ||
                        words[x].Substring(words[x].Length - 3) == "er?" ||
                        words[x].Substring(words[x].Length - 3) == "er!" ||
                        words[x].Substring(words[x].Length - 3) == "er,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 3, 2);
                        wordLength = wordLength - 2;
                    }
                }
                if (wordLength >= 2)
                {
                    if (words[x].Substring(words[x].Length - 2) == "er")
                    {
                        if (words[x] != "over" && words[x] != "Over" &&
                            words[x] != "other" && words[x] != "Other")
                        {
                            words[x] = words[x].Remove(words[x].Length - 2);
                            wordLength = wordLength - 2;
                        }

                    }
                }

                //able
                if (wordLength >= 5)
                {
                    if (words[x].Substring(words[x].Length - 5) == "able." ||
                        words[x].Substring(words[x].Length - 5) == "able?" ||
                        words[x].Substring(words[x].Length - 5) == "able!" ||
                        words[x].Substring(words[x].Length - 5) == "able,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 5, 4);
                        wordLength = wordLength - 4;
                    }
                }
                if (wordLength >= 4)
                {
                    if (words[x].Substring(words[x].Length - 4) == "able")
                    {
                        words[x] = words[x].Remove(words[x].Length - 4);
                        wordLength = wordLength - 4;
                    }
                }

                //ing
                if (wordLength >= 4)
                {
                    if (words[x].Substring(words[x].Length - 4) == "ing." ||
                        words[x].Substring(words[x].Length - 4) == "ing?" ||
                        words[x].Substring(words[x].Length - 4) == "ing!" ||
                        words[x].Substring(words[x].Length - 4) == "ing,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 4, 3);
                        wordLength = wordLength - 2;
                    }
                }
                if (wordLength >= 3)
                {
                    if (words[x].Substring(words[x].Length - 3) == "ing")
                    {
                        words[x] = words[x].Remove(words[x].Length - 3);
                        wordLength = wordLength - 3;
                    }
                }

                //s
                if (wordLength >= 2)
                {
                    if (words[x].Substring(words[x].Length - 2) == "s." ||
                        words[x].Substring(words[x].Length - 2) == "s?" ||
                        words[x].Substring(words[x].Length - 2) == "s!" ||
                        words[x].Substring(words[x].Length - 2) == "s,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 2, 1);
                        wordLength = wordLength - 1;
                    }
                }
                if (wordLength >= 1)
                {
                    if (words[x].Substring(words[x].Length - 1) == "s")
                    {
                        if (words[x] != "was" && words[x] != "is" &&
                            words[x] != "miss" && words[x] != "cross")
                        {
                            words[x] = words[x].Remove(words[x].Length - 1);
                            wordLength = wordLength - 1;
                        }
                    }
                }

                //ship
                if (wordLength >= 5)
                {
                    if (words[x].Substring(words[x].Length - 5) == "ship." ||
                        words[x].Substring(words[x].Length - 5) == "ship?" ||
                        words[x].Substring(words[x].Length - 5) == "ship!" ||
                        words[x].Substring(words[x].Length - 5) == "ship,")
                    {
                        words[x] = words[x].Remove(words[x].Length - 5, 4);
                        wordLength = wordLength - 4;
                    }
                }
                if (wordLength >= 4)
                {
                    if (words[x].Substring(words[x].Length - 4) == "ship")
                    {
                        if (words[x].Length != 4) //if the word enterd is just ship don't remove
                        {
                            words[x] = words[x].Remove(words[x].Length - 4);
                            wordLength = wordLength - 4;
                        }
                    }
                }
            }

            //Recombine all the words into a single string
            string filteredString = "";
            for (int x = 0; x < words.Length; x++)
            {
                if (filteredString == "") //run this if the filteredString is empty
                {
                    if (words[x] != "")
                    {
                        filteredString = filteredString + words[x];
                    }
                }
                else if (words[x] != "") //run this if the filteredString is not empty
                {
                    filteredString = filteredString + " " + words[x];
                }
            }
            //return the string
            return filteredString;
        }

        public string String_Sort(string s, int sortingMethod)
        {
            //This is a elective service
            //This service takes a string as input and sorts the string in alphabetical order
            //It also takes an int as input to allow the user to select what sorting algorithm to use
            //1 = bubble sort  2 = selection sort
            //It then returns the sorted string as a string.
            
            //1st break the string into an array of strings (1 word per element)
            string[] words = s.Split(' ');

            //sort the words
            //1) Bubble sort
            if (sortingMethod == 1)
            {
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                string temp;

                for (int x = 0; x < words.Length - 1; x++)
                {
                    for (int i = x + 1; i < words.Length; i++)
                    {
                        if (comparer.Compare(words[x], words[i]) > 0)
                        {
                            temp = words[x];
                            words[x] = words[i];
                            words[i] = temp;
                        }
                    }
                }
            }

            //2) Selection sort
            else if(sortingMethod == 2)
            {
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                for(int x = 0; x < words.Length-1; x++)
                {
                    int min_index = x;
                    string temp = words[x];

                    for(int y = x + 1; y < words.Length; y++)
                    {
                        if(words[y].CompareTo(temp) < 0)
                        {
                            temp = words[y];
                            min_index = y;
                        }
                    }

                    if(min_index != x)
                    {
                        string temp2 = words[min_index];
                        words[min_index] = words[x];
                        words[x] = temp2;
                    }
                }
            }else
            {
                return "Invalid sort number, try 1 or 2";
            }

            //Recombine all the words into a single string
            string filteredString = "";
            for (int x = 0; x < words.Length; x++)
            {
                if (filteredString == "") //run this if the filteredString is empty
                {
                    if (words[x] != "")
                    {
                        filteredString = filteredString + words[x];
                    }
                }
                else if (words[x] != "") //run this if the filteredString is not empty
                {
                    filteredString = filteredString + " " + words[x];
                }
            }
            
            //return the string
            return filteredString;
        }

        public int CharacterCounter(string s)
        {
            //This is an elective service
            //The service takes a string as input and counts up
            //  all the characters in the string (excluding spaces)
            //  returns an int
            int count = 0;

            //1st break the string into a string array
            string[] words = s.Split(' ');

            //Now go through the array counting the number of characters in each string
            for(int x = 0; x < words.Length; x++)
            {
                string word = words[x];
                count = count + word.Length;
            }

            return count;
        }

        public bool Password(string s)
        {
            //This is an elective service
            //It takes a string input and checks to see if it matches any of the valid passwords
            //It returns a boolean
            if (s == "CSE445" || s == "Group65")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Upper_Lower_DoubleSpace(string s, int action)
        {
            if(action == 0) //Convert the string to all uppercase
            {
                return s.ToUpper();
            }

            if(action == 1)
            {
                return s.ToLower();
            }
            
            if(action == 2) //add an extra space in-between each word
            {
                //1st break the string into an array of strings (1 word per element)
                string[] words = s.Split(' ');

                //Now add the words back with an extra space inbetween each word
                string filteredString = "";
                for (int x = 0; x < words.Length; x++)
                {
                    if (filteredString == "") //run this if the filteredString is empty
                    {
                        if (words[x] != "")
                        {
                            filteredString = filteredString + words[x];
                        }
                    }
                    else if (words[x] != "") //run this if the filteredString is not empty
                    {
                        filteredString = filteredString + "  " + words[x];
                    }
                }

                //return the string
                return filteredString;

            }

            else
            {
                return "Please enter a valid action (1 = uppercase, 2 = lowercase, 3 = double spaced";
            }
            
 



        }
    }
}
