class User
{
    const int maxCount = 6;
    class Programer
    {
        void SearchForUser(bool promenliva)
        {
            string personalNumberAsString = personalNumber.ToString();
            Console.WriteLine(personalNumberAsString);
        }
    }
    public static void InputInformation()
    {
        User.Programer instance =
          new User.Programer();
        instance.SearchForUser(true);
    }
}
