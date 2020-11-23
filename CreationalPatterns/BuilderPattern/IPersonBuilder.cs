using BuilderPattern.CarParts;

namespace BuilderPattern {
  interface IPersonBuilder {
    PersonBuilder AddName(string name);
    PersonBuilder AddAge(int age);
    PersonBuilder AddSex(string sex);
    PersonBuilder AddEmail(string email);
    PersonBuilder AddPhone(Phone phone);
    PersonBuilder AddAddress(string address);
    PersonBuilder AddCountry(Country country);
    PersonBuilder AddNation(Nation nation);
    Person Build();
  }
}