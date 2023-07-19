class Bank
{
    static void Main()
    {
        System.Console.WriteLine("*********Local Bank************");
        System.Console.WriteLine("**** Login Page ****");

        string userName = null, password = null;

        System.Console.WriteLine("Enter the Username");
        userName = System.Console.ReadLine();

        if (userName != null)
        {
            System.Console.WriteLine("Enter the Password");
            password = System.Console.ReadLine();
            //test comments  
        }

        if (userName == "Yash" && password == "Bank@123")
        {
            int mainMenuChoice = -1;
            do
            {
                System.Console.WriteLine(" Main Menu");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.WriteLine("Enter your choice");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Please enter the right credentials and try again");
        }

        System.Console.WriteLine(" Thank you! Visit Again");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        int customersMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n ::: Customers Menu ::: ");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");
            System.Console.WriteLine("Enter Choice");
            customersMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (customersMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        int accountsMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n ::: Accounts Menu ::: ");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");
            System.Console.WriteLine("Enter Choice");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (accountsMenuChoice != 0);
    }
}
