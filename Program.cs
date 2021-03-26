using System;

using System;

namespace templateReplace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // storing the template in a string called template.
            string template = "This [adjective] sentence has an adjective. My [adjective] [noun] likes to [verb].";
            // making the variable output to be read at the end, and setting it to an empty string.
            string output = "";
            // setting up a switch for either looking at brackets or adding to the output.
            bool bracket = false;
            // location to store the word that's in the brackets.
            string bracketWord = "";

            // forloop looking at every position inside the template to add either letter to output or bracketWord.
            for (int i = 0; i < template.Length; i++)
            {
                // if the position contains "[" start adding to bracketWord variable.
                if (template[i] == '[')
                {
                    bracket = true;
                }
                // Either add current position to bracketWord or output.
                if (bracket == false)
                {
                    output = output + template[i];
                }
                else
                {
                    bracketWord += template[i];
                }
                // if the position contains "]" it reads what is inbetween the two brackets, calls out bracketed word, and then asks user for word.
                if (template[i] == ']')
                {
                    Console.WriteLine("Give me a(n)" + bracketWord);
                    string input = Console.ReadLine();
                    output += input;
                    bracket = false;
                    bracketWord = "";
                }
            }

            Console.WriteLine(output);



            //•Get template
            //•make variable to store output
            //•Create variable for bracketed word
            //•Find first bracketed word:
            //	•scan each letter
            //	•if it is an ‘[‘
            //		•record into bracketed word variable until you hit ‘]’
            //		•get user input / store in variable
            //		•replace bracketed word with user input
            //•print results

            // make function

        }
    }
}


