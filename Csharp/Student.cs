using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Exercise.Csharp
{
    class Student
    {
        private string _name;
        public string Namesv
        {

            get
            {
                return "sv" + this._name;

            }
            set
            {
                this._name = value;
            }

        }

        public int Id { get; set; }

        private string _password;
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                HashAlgorithm hassword = new MD5CryptoServiceProvider();
                byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(value));
                this._password = Convert.ToBase64String(hassbyte);
            }
        }
    }
}