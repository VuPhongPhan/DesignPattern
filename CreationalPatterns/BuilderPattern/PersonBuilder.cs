using BuilderPattern.CarParts;

namespace BuilderPattern
{
    class PersonBuilder : IPersonBuilder
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public Phone Phone { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public Nation Nation { get; set; }


        public PersonBuilder AddName(string name)
        {
            Name = name;
            return this;
        }

        public PersonBuilder AddAge(int age)
        {
            Age = age;
            return this;
        }

        public PersonBuilder AddSex(string sex)
        {
            Sex = sex;
            return this;
        }

        public PersonBuilder AddEmail(string email)
        {
            Email = email;
            return this;
        }

        public PersonBuilder AddPhone(Phone phone)
        {
            Phone = phone;
            return this;
        }

        public PersonBuilder AddAddress(string address)
        {
            Address = address;
            return this;
        }

        public PersonBuilder AddCountry(Country country)
        {
            Country = country;
            return this;
        }

        public PersonBuilder AddNation(Nation nation)
        {
            Nation = nation;
            return this;
        }
        public Person Build()
        {
            return new Person(Name, Age, Sex, Email, Phone, Address, Country, Nation);
        }
    }
}