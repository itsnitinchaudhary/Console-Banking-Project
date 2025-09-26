class Program
{
    static void Main()
    {
        System.Console.WriteLine("***** My Bank *****");
        System.Console.WriteLine("----- Login Page -----");

        string userName = null, password = null;

        System.Console.Write("Username : ");
        userName = System.Console.ReadLine();

       if(userName != "")
        {
            System.Console.Write("password : ");
            password = System.Console.ReadLine();
        }

        if (userName == "Nitin" && password == "Chaudhary")
        {
            int mainmenuchoice = -1;
            do
            {
                

                System.Console.WriteLine("\n:: Main Menu ::");
                System.Console.WriteLine("1. Customer");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Fund Transfer");
                System.Console.WriteLine("4. Fund Transfer statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.WriteLine("Enter Choice : ");
                mainmenuchoice = int.Parse(Console.ReadLine());


                switch (mainmenuchoice)
                {
                    case 1: CustomerMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3:
                        FundsTransfer();
                        break;
                    case 4:
                        FundsTransferStatement();
                        break;
                    case 5:
                        AccountStatement();
                        break;
                }
            } while (mainmenuchoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password.");
        }

        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();
           
    }

    static void CustomerMenu()
    {
        int customermenuchoice = -1;

        do
        {
            Console.WriteLine("::: Customer Menu :::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customer");
            Console.WriteLine("0. Back to main menu");

            System.Console.WriteLine("Enter choice : ");
            customermenuchoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (customermenuchoice != 0);
    }

   static void AccountsMenu()
    {
        int accountsmenuchoice = -1;

        do
        {
            Console.WriteLine("::: Accounts Menu :::");
            Console.WriteLine("1. Account holder's name");
            Console.WriteLine("2. Account number");
            Console.WriteLine("3. IFSC code");
            Console.WriteLine("4. Branch name");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter choice : ");
            accountsmenuchoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountsmenuchoice != 0);
    }

    static void FundsTransfer()
    {
        int fundstransferchoice = -1;

        do
        {
            Console.WriteLine("::: Funds Transfer :::");
            Console.WriteLine("1. Sender's Name");
            Console.WriteLine("2. Sender's Account Number");
            Console.WriteLine("3. Reciever's Name");
            Console.WriteLine("4. Reciever's Account Number");
            Console.WriteLine("5. Amount Transfered");
            Console.WriteLine("6. Date of Transaction");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter choice : ");
            fundstransferchoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (fundstransferchoice != 0);
    }

    static void FundsTransferStatement()
    {
        int fundstatementchoice = -1;

        do
        {
            Console.WriteLine("::: Funds Transfer Statement :::");
            Console.WriteLine("1. Select Starting Date");
            Console.WriteLine("2. Select End Date");
            Console.WriteLine("3. Download Statement");
            Console.WriteLine("4. Select Format");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter choice : ");
            fundstatementchoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (fundstatementchoice != 0);
 
   }

    static void AccountStatement()
    {
        int accountstatementchoice = -1;

        do
        {
            Console.WriteLine("::: Account Statement :::");
            Console.WriteLine("1. Select Starting Date");
            Console.WriteLine("2. Select End date");
            Console.WriteLine("3. Download Statement");
            Console.WriteLine("4. Select Format");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter choice");
            accountstatementchoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountstatementchoice != 0);
    }
}