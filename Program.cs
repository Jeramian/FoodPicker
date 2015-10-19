using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatShouldIEat
{
    class Program
    {
        static void Main(string[] args)
        {
            //shows programs name
            name();

            //This generates a random number
            Random randomObject = new Random();

            while (true)
            {
                    string getQuestion = getQuestionFromUser();

                    //user no entry
                    if (getQuestion.Length == 0)
                    {
                        Console.WriteLine("You need to type a question!");
                        continue;
                    }

                    //user exit
                    if(getQuestion.ToLower() == "exit")
                    {
                        break;
                    }

                    //mind change
                    if(getQuestion.ToLower() == "nevermind")
                    {
                        Console.WriteLine("Okay, try again later! Bye!");
                        Console.ReadLine();
                        break;
                    }

                     //get random number
                    int randomNumber = randomObject.Next(5);

                    //uses random number to invoke a response to the user
                    switch (randomNumber)
                    {

                        //if 0 do this
                        case 0:
                            {
                                Console.WriteLine("Chineese");
                                break;
                            }
                        //if 1 do this
                        case 1:
                            {
                                Console.WriteLine("Mexican");
                                break;
                            }
                        //if 2 do this
                        case 2:
                            {
                                Console.WriteLine("Burgers");
                                break;
                            }
                        //if 3 do this
                        case 3:
                            {
                                Console.WriteLine("Fast-Food");
                                break;
                            }
                        //if 4 do this
                        case 4:
                            {
                                Console.WriteLine("Make something yourselves");
                                break;
                            }
                    }//end of loop
                }            
        }

        //Programs name
        public static void name()
        {
            Console.WriteLine("What should we eat?");
        }

        //this code asks for the users question and then stores it as a read line
         static string getQuestionFromUser()
        {
            Console.Write("Enter question here: ");
            string getQuestion = Console.ReadLine();
            return getQuestion;
        }
    }
}
