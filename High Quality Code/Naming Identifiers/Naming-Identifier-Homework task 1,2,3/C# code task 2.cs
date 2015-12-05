class MainClass
{
  enum Gender { Male, Female };

  class Person
  {
    public Gender gebder { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
  }
  public void MakePerson(int identificationNumber)
  {
      person newPerson = new person();
      newPerson.Age = identificationNumber;
      if (identificationNumber % 2 == 0)
      {
          newPerson.Name = "Batkata";
          newPerson.Gender = Gender.male;
      }
      else
      {
          newPerson.Name = "Matceto";
          newPerson.Gender = Gender.female;
      }
  }
}
