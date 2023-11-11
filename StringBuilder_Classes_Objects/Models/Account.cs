using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Classes_Objects.Models
{
    class Account
    {
        public string userName;
        public string password;

        public void login(string userName, string password)
        {
            this.userName = userName;
            this.password = password;

            if (this.userName=="lorem123" && this.password == "123456*")
            {
                Console.WriteLine("Giris ugurludur");
            }
            else 
            {
                Console.WriteLine("email ve ya password sehvdir");
            }
        }
    }
}
