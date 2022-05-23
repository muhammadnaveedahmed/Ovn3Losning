namespace Ovn3Dado
{
    public class Person
    {
        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be more than 0.");
                }
                age = value;

            }
        }

        private string firstName = "";

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must be between 2 and 10 characters.");
                }
                firstName = value;
            }
        }

        private string lastName = "";

        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must be between 3 and 15 characters.");
                }
                lastName = value;
            }
        }

        public double Height { get; set; }

        public double Weight { get; set; }

        public Person()
        {

        }

        public Person(int age, string firstName, string lastName, double height, double weight)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"First name: {FirstName} | Last name: {LastName} | Age: {Age} | Height: {Height} | Weight: {Weight}.";
        }

    }
}
