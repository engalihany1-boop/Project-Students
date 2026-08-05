using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Students
{
    public abstract class Person
    {
        protected string Name;
        protected string ID;
        protected string Email;
        protected string Phone;

        public Person(string name, string id, string email, string phone)
        {
            Name = name;
            ID = id;
            Email = email;
            Phone = phone;
        }

        public string GetName() => Name;
        public string GetID() => ID;
        public string GetEmail() => Email;
        public string GetPhone() => Phone;

        public abstract string GetInfo();

        public override string ToString() => Name + " (" + ID + ")";
    }
}
