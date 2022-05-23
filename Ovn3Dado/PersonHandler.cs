namespace Ovn3Dado
{
    internal class PersonHandler
    {

        public void SetAge(Person pers, int newAge)
        {
            pers.Age = newAge;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            var person = new Person(age, fName, lName, height, weight);

            return person;
        }

    }
}
