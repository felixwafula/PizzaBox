using System.IO;

namespace PizzaBox.Domain.Models
{
    public class User
    {
        private const string path = @"C:\revature\project-0\PizzaBoxApp\TempStore\Users.txt";

        //properties
        public static string Path => path;
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string address { get; set; }
        private string userName { get; set; }
        private string password { get; set; }

        //constructor
        public User()
        {

        }
        //methods
        public void CreateNewUser()
        {   //Getting names and address.
            System.Console.WriteLine("Enter your first name: ");
            firstName = System.Console.ReadLine();
            System.Console.WriteLine("Enter your last name: ");
            lastName = System.Console.ReadLine();
            System.Console.WriteLine("Enter you address: ");
            address = System.Console.ReadLine();

            //Getting the userName from the new user.
            System.Console.WriteLine("Enter username:");
            userName = System.Console.ReadLine();

            //Getting the password from the new user.
            System.Console.WriteLine("Enter a Password:");
            password = System.Console.ReadLine();

            //save the password to a store.
            this.SaveCredentials(userName, password);



        }
        //THis method needs to tak in an object called user.
        public void SaveCredentials(string userName, string password)
        {
            using (StreamWriter sw = new StreamWriter(File.Create(Path)))
            {

                sw.WriteLine(userName);
                sw.WriteLine(password);
                sw.Close();
            }
            System.Console.WriteLine("Registration successful! Please login to continue");
            this.UserLogin();
        }

        //User login.
        public void UserLogin()
        {
            string loginName;
            string loginPassword;
            string signUpName;
            string signUpPassword;

            //login details from user.
            System.Console.WriteLine("Enter your username: ");
            loginName = System.Console.ReadLine();
            System.Console.WriteLine("Enter your password: ");
            loginPassword = System.Console.ReadLine();

            using (StreamReader sr = new StreamReader(File.Open(Path, FileMode.Open)))
            {
                signUpName = sr.ReadLine();
                signUpPassword = sr.ReadLine();
                sr.Close();
            }
            if (loginName == signUpName && loginPassword == signUpPassword)
            {
                System.Console.WriteLine("Login succesful! Welcome to PizzaBox! Select a location: ");
            }
            else if (loginName != signUpName)
            {
                System.Console.WriteLine("This user doesnt exist. Please register");
                this.CreateNewUser();
            }
            else
            {
                System.Console.WriteLine("Login failed: Trry again");
                this.UserLogin();
            }


        }


    }
}
