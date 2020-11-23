using System;
using BuilderPattern.CarParts;

namespace BuilderPattern
{
  class Program
  {
    static void Main(string[] args)
    {
            var person = new Person("Phong", 
                                    22, 
                                    "Nam", 
                                    "Vuphongshyn1998@gamil.com", 
                                    new Phone("0359276161"), 
                                    "Quang Binh", 
                                    new Country("Viet Nam"), 
                                    new Nation("Kinh"));
      
      var personByBuilder = new PersonBuilder()
                                .AddName("Phong")
                                .AddAge(22)
                                .AddSex("Nam")
                                .AddEmail("Vuphongshyn1998@gamil.com")
                                .AddPhone(new Phone("0359276161"))
                                .AddAddress("Quang Binh")
                                .AddCountry(new Country("Viet Nam"))
                                .AddNation(new Nation("Kinh"))
                                .Build();
      Console.WriteLine(person.ToString());
      Console.WriteLine("------------------------------------");
      Console.WriteLine(personByBuilder.ToString());
    }
  }
}
