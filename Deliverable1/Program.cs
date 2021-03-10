using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)

        {
            //set up the variables for the user inputs
            double userNumber;
            double inchToFs;
            double fsToInch;
            double ftToMeme;
            double memeToFt;
            string userPlay;


            //asking the user to provide the userinputs ... set up the measurement type into a string and parse the amount the user amount into a number
           
            do
            {

                Console.Write("Input an amount ");
                string userAmount = Console.ReadLine();
                userNumber = double.Parse(userAmount);    
                
                Console.Write("Input a unit ");
                string inputUnit = Console.ReadLine().ToLower();               
                
                                
                //Console.WriteLine(inputUnit);

                // Next check the input units and convert the amount based upon the table.
                // convert the measurement type .. if inch, then fidget spinners & viceversa; if foot, then memes & viceversa. 

                
                if (inputUnit == "inch")
                {
                    inchToFs = userNumber * 3.5;
                    Console.WriteLine(userAmount + " inches is " + inchToFs + " fidget spinners.");
                }

                if (inputUnit == "fidget spinner")
                {
                    fsToInch = userNumber / 3.5;
                    Console.WriteLine(userAmount + " fidget spinners is " + fsToInch + " inches");
                }

                if (inputUnit == "feet")
                {
                    ftToMeme = userNumber * 5;
                    Console.WriteLine(userAmount + " feet is " + ftToMeme + " memes");
                }

                if (inputUnit == "meme")
                {
                    memeToFt = userNumber / 5;
                    Console.WriteLine(userAmount + " memes is " + memeToFt + " feet");
                }



                // ask if they want to try again
                // accept input yes or no
                // if yes, loop to enter input
                // if no, write line game over & end. 

                Console.WriteLine("Do you want to play again (Y or N)?");
                userPlay = Console.ReadLine().ToLower();

            } while (userPlay == "y");

               
            










        }
    }
}
