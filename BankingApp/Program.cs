/* Week 1 BankingApp
 * Author: Mark Stewart
 * Version 1
 */
void BuildBankingApp()
{
    //Initalise variable
    //Note that an amount is not assigned to the variable
    int choice;

    //Display main menu screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    //Read user input
    //Convert string to an integer
    //using explicit typecasting

    choice = Convert.ToInt32(Console.ReadLine());

    //The || in the loop represents OR
    //which means that a menu choice is 1 OR 2
    //is accepted for this logical operation
    if (choice == 1 || choice == 2)
    {
        //Valid choice menu
        if (choice == 1)
        {
            //Deposit or withdraw funds
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter amount including pence using a decimal point");

            //Typically a currency value is input as a decimal value
            //so the "double" type is required to store deposit amount

            depositAmount = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            //View current account information
            Console.WriteLine("You have chosen to view current account information");
        }
    }
    else
    {
        //Invalid menu choice
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}