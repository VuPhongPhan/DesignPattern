using System.Collections.Generic;
using BuilderPattern.CarParts;

namespace BuilderPattern
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public Phone Phone { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public Nation Nation { get; set; }

        public Person(string name,
                   int age,
                   string sex,
                   string email,
                   Phone phone,
                   string address,
                   Country country,
                   Nation nation)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Email = email;
            Phone = phone;
            Address = address;
            Country = country;
            Nation = nation;
        }

        public override string ToString()
        {
            var content = "";
            content += $"Ten:   \t\t {Name}\n";
            content += $"Tuoi:  \t\t {Age}\n";
            content += $"Gioi Tinh:\t {Sex}\n";
            content += $"Email: \t\t {Email}\n";
            content += $"So Dien Thoai: \t {Phone.Name}\n";
            content += $"Dia Chi:\t {Address}\n";
            content += $"Quoc Gia:\t {Country.Name}\n";
            content += $"Dan Toc:\t {Nation.Name}\n";
            return content;
        }
    }
}