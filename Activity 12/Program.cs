using System;
using System.IO;
public class HelloWorld
{
    public static void Main()
    {
        try //begin exception handling
        {
            // Create varibales. 
            int i;
            int word;
            int l;


            //Create string variable. 
            string str = System.IO.File.ReadAllText("Input.txt");

            l = 1;
            word = 1;

            // Create loop that will end once it reaches the end of the string
            while (l <= str.Length - 1)
            { 
                if ((str[l] == '.' || str[l] == ' ' || str[l] == '\t' || str[l] == '!' || str[l] == ',' || str[l] == '?' || str[l] == '\n') && (str[l - 1] == 't' || str[l - 1] == 'e'))
                {
                    word++;
                }

                l++;
            }
            Console.Write("There are {0} words ending in t or e", word);
        }
        catch (Exception ex) //end exception handler
        {
            Console.WriteLine(ex.ToString());
        }


    }
}