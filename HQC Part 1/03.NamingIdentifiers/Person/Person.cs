namespace Person
{
    public class PersonFactory
    {
        public enum Gender
        {
            Male,
            Female
        }

        public Person GetHuman(int age)
        {
            Person currentPerson = new Person { Age = age };

            if (age % 2 == 0)
            {
                currentPerson.Name = "Adam";
                currentPerson.Gender = Gender.Male;
            }
            else
            {
                currentPerson.Name = "Eve";
                currentPerson.Gender = Gender.Female;
            }

            return currentPerson;
        }

        public class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public Gender Gender { get; set; }
        }
    }
}
