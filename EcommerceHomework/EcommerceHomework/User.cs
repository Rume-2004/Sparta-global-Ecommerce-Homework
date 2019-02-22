using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace EcommerceHomework
{
    class User
    {
        string name;
        public string Name { get => name; set => name = value; }

        string password;
        public string Password { get => password; set => password = value; }

        int age;
        public int Age { get => age; set => age = value; }

        string sex;
        public string Sex { get => sex; set => sex = value; }

        string phoneNumber;
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        string picturePath;
        public string PicturePath { get => picturePath; set => picturePath = value; }

        string Newsletter;
        public string newsletter { get => Newsletter; set => Newsletter = value; }

        string[] GDPR = new string[4];
        public string[] GDPR1 { get => GDPR; set => GDPR = value; }

        string email;
        public string Email { get => email; set => email = value; }

        public User()
        {

        }
        public User(string n, string p, int a, string s, string em, string pN, string pP, string nL, string[] c)
        {
            name = n;
            password = p;
            age = a;
            sex = s;
            email = em;
            phoneNumber = pN;
            picturePath = pP;
            Newsletter = nL;
            GDPR = c;
        }

        public void saveData()
        {
            using (StreamWriter sw = File.AppendText("UserData.txt"))
            {
                string eachItem = "";
                foreach (var item in GDPR)
                {
                    eachItem += "-" + item;
                }

                sw.WriteLine(name + "," + password + "," + age + "," + sex + ","+ email +"," + phoneNumber + "," + picturePath + "," + Newsletter + "," + eachItem);

            }
        }
    }
}
