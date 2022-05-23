namespace Ovn3Dado
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name} | Age: {Age} | ";
        }
    }

    public class Horse : Animal, IPerson
    {

        public int Speed { get; set; }

        public Horse(string name, int age, int speed) : base(name, age)
        {
            Speed = speed;
        }

        public override string DoSound()
        {
            return "*Neigh!*";
        }

        public override string Stats()
        {
            return base.Stats() + $"Speed: {Speed}";
        }

        public string Talk()
        {
            return "I'm a Centaur!";
        }
    }

    public class Dog : Animal
    {

        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public override string DoSound()
        {
            return "*BARK!*";
        }

        public override string Stats()
        {
            return base.Stats() + $"Breed: {Breed}";
        }

    }

    public class Wolf : Animal
    {

        public int NrOfPackMembers { get; set; }

        public Wolf(string name, int age, int nrOfPackMembers) : base(name, age)
        {
            NrOfPackMembers = nrOfPackMembers;
        }


        public override string DoSound()
        {
            return "*HOWL*";
        }

        public override string Stats()
        {
            return base.Stats() + $"Number of pack members: {NrOfPackMembers}";
        }
    }

    public class Wolfman : Wolf, IPerson
    {
        public bool IsCursed { get; set; }
        public Wolfman(string name, int age, int nrOfPackMembers, bool isCursed) : base(name, age, nrOfPackMembers)
        {
            IsCursed = isCursed;
        }

        public string Talk()
        {
            return "Please lift my curse!";
        }
    }
}
