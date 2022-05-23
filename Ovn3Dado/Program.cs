using Ovn3Dado;

//try
//{
//    var personHandler = new PersonHandler();
//    //var person1 = new Person(4, "Test", "Testsson", 180.0, 80.0);
//    var person1 = personHandler.CreatePerson(4, "Test", "Testsson", 180.0, 80.0);
//    personHandler.SetAge(person1, 5);
//    //Console.WriteLine($"Age: {person1.Age}, First name: {person1.FirstName}....");
//    Console.WriteLine(person1.ToString());

//}
//catch (Exception e)
//{

//    Console.WriteLine(e.Message);
//}



var animalList = new List<Animal>
{
    new Horse("Lille Skutt", 5, 30),
    new Dog("Fido", 3, "Golden Retriever"),
    new Wolf("Bob", 10, 4),
    new Wolfman("Malin", 45, 2, true)

};

foreach (var animal in animalList)
{
    Console.WriteLine();
    Console.WriteLine(animal.Stats());
    Console.WriteLine(animal.DoSound());
    //Console.WriteLine(animal.Talk());
    if (animal is IPerson)
    {
        IPerson tempPerson = (IPerson)animal;
        Console.WriteLine(tempPerson.Talk());
    }

    Console.WriteLine();
}




