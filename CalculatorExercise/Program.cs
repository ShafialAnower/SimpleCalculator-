namespace CalculatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double num1, num2, calc = 0;  //need to initalize variable to avoid use of unassigned local variable error 
            string input1, input2;
            do
            {

                try
                {
                    Console.WriteLine("Hello, this is a Console Calculator Application.");
                    Console.WriteLine("-----------------------------");



                    Console.Write("Enter a number: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Select what operation would you like to perform: + - / *");
                    input1 = Console.ReadLine();




                    switch (input1)
                    {
                        case "+":
                            calc = num1 + num2;
                            Console.WriteLine(calc);
                            break;
                        case "-":
                            calc = num1 - num2;
                            Console.WriteLine(calc);
                            break;
                        case "/":
                            calc = num1 / num2;
                            Console.WriteLine(calc);
                            break;
                        case "*":
                            calc = num1 * num2;
                            Console.WriteLine(calc);
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Info: " + ex.Message);  //general exception
                }


                do
                {
                    Console.Write("Do you want the try another calculation: (Y/N) "); // If selecting Y or any other letter the application will continue regardless 
                    input2 = Console.ReadLine().ToUpper();

                    if (input2 != "Y" && input2 != "N")
                    {
                        Console.WriteLine("Please select between (Y/N) ");
                    }



                } while (input2 != "Y" && input2 != "N");
                Console.Clear();


            }
            while (input2 == "Y");  //Condition: False -> end || True -> Continue 
            Console.WriteLine("<----Application Ended---->");


        }

    }
}

//add divison,  try to do calculation with the result, handle the exception with bad input

/*Do another calculation with the result:
 * Get the result from the first calculation
 * Ask the user if they want to a calculation to the exsisting calculation 
 * If yes perform the calculation on the result 
 */
