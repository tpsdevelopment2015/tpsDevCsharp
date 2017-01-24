//this simple program was written to help my kids with their math homework. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MathGame
{
    class Program
    {


        static void Main(string[] args)
        {
            //bool go = true;

            Console.WriteLine("***THE MATH + GAME = \"THE MATH GAME\"***\n");
            Thread.Sleep(3000);
            Console.Write("Let's PLAY!! Please TYPE your FIRST NAME:  ");
            string name = Console.ReadLine();

            Console.Write("\nHello " + name + " Let's PLAY the MATH GAME!!!\n\n\n");
            Thread.Sleep(3000);
            //Console.Read();



            //need a while loop to start here to ask if yes or no.
            string question = "TYPE the answer to:  ";
            int userAnswer;
            string userInput;
            int count = 1;
            int queNum = 1;
            int numCorrect = 0;

            while (count <= 10)
            {
                Random random0 = new Random();
                Random random1 = new Random();
                Random random2 = new Random();
                int num0 = random0.Next(1, 3);
                int num1 = random1.Next(0, 100);
                int num2 = random2.Next(0, 50);



                switch (num0)
                {
                    

                    case 1:
                        Console.Write(queNum.ToString() + "). " + question);
                        queNum++;
                        Console.Write(num1 + " + " + num2 + " = ");
                        
                        
                        
                        
                            userInput = Console.ReadLine();
                            //THIS IF AND ELSE STATEMENT NEEDS TO BE ON ALL "FIX IT!!"
                            if (int.TryParse(userInput, out userAnswer))
                            {

                                //userAnswer = Int32.Parse(userInput);

                                if (userAnswer == (num1 + num2))
                                {
                                    Console.WriteLine("CORRECT! Good Job " + name + "!");
                                    count++;
                                    numCorrect++;
                                   
                                   
                                }
                                else
                                {
                                    Console.WriteLine("SORRY, try again.");
                                    count++;
                                   
                                }
                            }
                            else { Console.WriteLine("SORRY!! YOU DID NOT ENTER A NUMBER."); }
                        
                        Console.ReadLine();
                        break;
                        

                    case 2:
                        if (num1 < num2)
                        {
                            Console.Write(queNum.ToString() + "). " + question);
                            queNum++;
                            Console.Write(num2 + " - " + num1 + " = ");

                            
                                userInput = Console.ReadLine();

                                if (int.TryParse(userInput, out userAnswer))
                                {
                                    //userAnswer = Int32.Parse(userInput);
                                    if (userAnswer == (num2 - num1))
                                    {
                                        Console.WriteLine("CORRECT! Good Job " + name + "!");
                                        count++;
                                        numCorrect++;
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("SORRY, try again.");
                                        count++;
                                       
                                    }
                                }
                                else { Console.WriteLine("SORRY!! YOU DID NOT ENTER A NUMBER."); }
                            
                            Console.ReadLine();
                            break;
                            
                        }
                        else
                        {
                            Console.Write(queNum.ToString() + "). " + question);
                            queNum++;
                            Console.Write(num1 + " - " + num2 + " = ");

                            
                                userInput = Console.ReadLine();
                                if (int.TryParse(userInput, out userAnswer))
                                {
                                    //userAnswer = Int32.Parse(userInput);
                                    if (userAnswer == (num1 - num2))
                                    {
                                        Console.WriteLine("CORRECT! Good Job " + name + "!");
                                        count++;
                                        numCorrect++;
                                       
                                    }
                                    else
                                    {
                                        Console.WriteLine("SORRY, try again.");
                                        count++;
                                        
                                    }
                                }
                                else { Console.WriteLine("SORRY!! YOU DID NOT ENTER A NUMBER.");  }
                          
                            Console.ReadLine();
                            break;
                            
                        }

                        break;

                }//end switch

                if (queNum == 11) {
                    Console.WriteLine("Your SCORE is:  " + numCorrect + "/10");
                    Console.ReadLine();
                    Console.WriteLine(name + ", do you want to Play again? Y = Yes : N = No");
                    string userInputYesNo = Console.ReadLine();

                    if (userInputYesNo == "y")
                    {
                        count = 1;
                        queNum = 1;
                        numCorrect = 0;
                    }
                    else {
                        break;
                    }

                }//end if queNum == 10

            }//end while



        }//end main()




    }//end class Program
}//end namespace

