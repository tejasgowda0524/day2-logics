using System.Collections;

namespace new1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Random r = new Random();
             int marks = r.Next(1, 100);*/

            /*int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"student obtained marks {marks}");
            
            
                if (marks <=59)
                {
                    Console.WriteLine("F");
                }
                else if (marks >=60  &&  marks <=69)
                {
                    Console.Write("D");
                }
                else if (marks >=70  &&  marks <=79)
                {
                    Console.Write("C");
                }
                else if (marks >=80  &&  marks <=89)
                {
                    Console.Write("B");
                }
                else
                {
                    Console.WriteLine("A");
                }
            
            Console.ReadLine();*/



            // 2.fehreinite to celcious or celcious to fehreinite

            /*  int celcious;
              int fehrenheit;
              Console.WriteLine("choose the type of conversion .. \n 1.fehreinite to celcious. \n 2.celcious to fehreinite");
              int choice = Convert.ToInt32(Console.ReadLine());

              switch (choice)
              {
                  case 1:
                      Console.WriteLine(" you are converting fehreinite to celcious");
                      Console.WriteLine("enter fehreinheit value");
                      fehrenheit = Convert.ToInt32(Console.ReadLine());
                      int calc = (fehrenheit-32);
                      double res = calc*0.56;            // (f-32)*5/9
                      Console.WriteLine("celcious is " + res);
                      break;
                  case 2:
                      Console.WriteLine(" you are converting celcious to fehreinite");
                      Console.WriteLine("enter celcious value");
                      celcious = Convert.ToInt32(Console.ReadLine());
                      double res1 = (celcious*(9/5))+32;
                      Console.WriteLine("celcious is " + res1);
                      break;


              }*/








            /* 3.    Write a C# program that calculates the price of a movie ticket based on
                     the age of the customer and the time of the movie.
                     Implement different pricing rules for children (under 12),
                     adults (12-64), and seniors (65+), and consider matinee discounts.*/


          /*  Console.WriteLine("enter your age..");
            int customerAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter how long you can watch movie?");
            float time = Convert.ToInt32(Console.ReadLine());
            int ticketPrice = 150;

            if (customerAge <12)
            {
                if (time == 1)
                {
                    double discount = (0.75*150);
                    Console.WriteLine("dear customer you can watch movie upto 45 mins");
                    Console.WriteLine($" we offering you 75% discount \n your movie ticket price is {ticketPrice-discount}");


                }
                else if (time>=1)
                {
                    Console.WriteLine("sorry you can watch movie upto 45 mins");
                }
            }
            else if (customerAge >=12 && customerAge<=64)
            {
                if (time == 2 || time==3)
                {
                    Console.WriteLine("dear customer you can watch movie upto 3 hrs");
                    Console.WriteLine(" we offering you Rs.150 ,Enjoy your movie");
                }
            }
            else
            {
                double discount1 = 0.5*150;
                Console.WriteLine("dear customer you can watch movie upto 3 hrs if possible");
                Console.WriteLine($" we offering you  50% discount , \n your movie ticket price is {ticketPrice-discount1},Enjoy your movie");
            }
            Console.ReadLine();*/









            /* 4.   Design a simple login system in C# where users provide their username and password.
                     Use conditional statements to check the credentials and provide appropriate feedback, 
                     such as successful login, incorrect username, incorrect password, or account locked.*/

            /*string correctUsername = "user123";
            string correctPassword = "pass456";

            int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.Write("Enter username: ");
                string enteredUsername = Console.ReadLine();

                Console.Write("Enter password: ");
                string enteredPassword = Console.ReadLine();

                if (enteredUsername == correctUsername && enteredPassword == correctPassword)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password. Please try again.");
                    attempts++;
                }
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine("Account locked. Too many unsuccessful login attempts.");
            }*/












            /* 5.   Implement a menu-driven calculator in C# that allows users to perform basic operations
                      (addition, subtraction, multiplication, division) Use conditional statements to execute
                        the selected operation and handle invalid inputs.*/





           /* Console.WriteLine("enter first number");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the operator");
            char c = Convert.ToChar(Console.ReadLine());
            if (c== '+')
            {
                Console.WriteLine(a + "+" + b + "=" +  (a+b));
            }
            else if (c== '-')
            {
                Console.WriteLine(a + "-" + b + "=" +  (a-b));
            }
            else if (c== '*')
            {
                Console.WriteLine(a + "*" + b + "=" +  (a*b));
            }
            else if (c== '/')
            {
                Console.WriteLine(a + "/" + b + "=" +  (a/b));
            }
            Console.ReadLine();*/











            /* 6.    Develop a C# program that calculates the Air Quality Index (AQI) based on the concentration of pollutants.
                    Use conditional statements to classify the AQI into different categories (Good, Moderate, Unhealthy, etc.) 
                    based on predefined thresholds for different pollutants.*/



            /* Console.WriteLine("the pollutants available now is : \n 1.carbonMonoxide\n 2.nitrogen oxide\n 3.sulpher Dioxide\n 4.greenhouse gases");
             Console.WriteLine("To know AQI of above pollutants ,enter the pollutants name in the list");
             string pollutants = Console.ReadLine();
             Console.WriteLine($"enter the ppm(parts per millian) of {pollutants} from 0-300");
             int ppm = Convert.ToInt32(Console.ReadLine());

             if (ppm<=50)
             {
                 Console.WriteLine($" ppm you entered is {ppm},air quality index of {pollutants} is GOOD .. ");
             }
             else if (ppm>50 && ppm<=100)
             {
                 Console.WriteLine($" ppm you entered is {ppm},air quality index of {pollutants} is NORMAL .. ");
             }
             else if (ppm>100 && ppm<=199)
             {
                 Console.WriteLine($" ppm you entered is {ppm},air quality index of {pollutants} is UNHEALTHY .. ");
             }
             else if (ppm>199 && ppm<=299)
             {
                 Console.WriteLine($" ppm you entered is {ppm},air quality index of {pollutants} is VERY UNHEALTHY .. ");
             }
             else if (ppm>300)
             {
                 Console.WriteLine($" ppm you entered is {ppm},air quality index of {pollutants} is HARMFUL .. ");
             }
             Console.ReadLine();


 */







            // 7.   Implement a simple rock, paper, scissors game in C#. Prompt the user to enter their choice,
            //       and use conditional statements to determine the winner based on the game rules
            //      (rock beats scissors, scissors beat paper, paper beats rock).



            /* Console.WriteLine("you have three options .. \n 1.rock \n 2.scissors \n 3.paper");
             Console.WriteLine("enter your choice (player1)");
             int player1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter your choice (player2)");
             int player2 = Convert.ToInt32(Console.ReadLine());

             if (player1==player2)
             {
                 Console.WriteLine("both choices are same re-run the program..to continue the game");
             }
             else if (player1 ==1 && player2==2)
             {
                 Console.WriteLine("rock beats scissor");
                 Console.WriteLine("player 1 won the game");
             }
             else if (player1 ==1 && player2==3)
             {
                 Console.WriteLine("paper beats rock");
                 Console.WriteLine("player 2 won the game");
             }
             else if (player1 ==2 && player2==3)
             {
                 Console.WriteLine("scissor beats paper");
                 Console.WriteLine("player 1 won the game");
             }
             else if (player1 ==3 && player2==2)
             {
                 Console.WriteLine("scissor beats paper");
                 Console.WriteLine("player 2 won the game");
             }

             Console.ReadLine();*/







            // 8 .   Design a C# program that calculates the fine for overdue library books.
            //      The program should take the number of days a book is overdue as input and apply
            //      different fine rates based on predefined rules (e.g., first 7 days free, after that $0.50 per day).




            /*Console.WriteLine("enter how much time (in days) you took to return the book?");
            int days = Convert.ToInt32(Console.ReadLine());
            if (days <=7)
            {
                Console.WriteLine($"there is no overdue fine for you..you returned the book in {7-days} days");
            }
            else if (days >7)
            {
                int day = days-7;
                double fine = 0.50 *days;
                Console.WriteLine($"there is overdue fine for you..you need to play ${fine} ");
            }
            Console.ReadLine();

*/





            // 9.   Create a C# program that simulates a traffic light. Implement a system where the light
            //      changes based on predefined time intervals. Use conditional statements to determine which
            //      color (Red, Yellow, Green) should be displayed at any given time.




            /* for (int i = 60; i>=0; i--)
             {
                 if (i<=60 && i>=30)
                 {

                     Console.WriteLine(i + " sec" + "       RED");
                     Thread.Sleep(800);

                 }
                 else if (i<=29 && i>=1)
                 {
                     Console.WriteLine(i + " sec" + "      YELLOW");
                     Thread.Sleep(800);
                 }
                 else
                 {
                     Console.WriteLine(i + " sec" + "      GREEN");
                     Thread.Sleep(800);
                 }
             }

 */

            // 10.   Design a library reservation system in C#. Allow users to check the availability of
            //       books and reserve them. Use conditional statements to manage the reservation process,
            //       considering factors like book availability, user limits, and reservation duration.


            /*ArrayList ar = new ArrayList();
            ar.Add("kannada");
            ar.Add("english");
            ar.Add("hindi");
            ar.Add("science");
            ar.Add("maths");
            ar.Add("social");
            ar.Add("java");
            ar.Add("python");
            ar.Add("c#");
            Console.Write(" currently library have this much of books : ");
            foreach (var num in ar)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("enter the book name to know whether its available or not");
            string sub = Console.ReadLine();




            if (ar.Contains(sub))
            {
                Console.WriteLine($"{sub} book is available now..you can reserve it now");
                Console.WriteLine("do you want to reserve the book?");
                string openion = Console.ReadLine();
                if (openion=="yes")
                {
                    Console.WriteLine("congradulation you reserved the book succesfully..");
                }
                else
                {
                    Console.WriteLine("your book is not reserved..");
                }
               


            }
            else
            {
                Console.WriteLine("the book you enteres is not available now..");
            }
            Console.ReadLine();
*/













        }
    }
}
