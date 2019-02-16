using System;


namespace Dog__
{

    enum Gender
    {
        Male,
        Female
    }

    public class Dog
    {
        public string Name;
        public string Owner;
        public int Age;

        internal Gender Gender { get; }

        public Type gender;

        internal Dog(string name, string owner, int age, Gender m_f)
        {
            Name = name;
            Owner = owner;
            Age = age;
            Gender = m_f;

            void WriteGender(Gender gender)
            {
                switch (gender)
                {
                    case Gender.Male:
                        Console.WriteLine("Male");
                        break;
                    case Gender.Female:
                        Console.WriteLine("Female");
                        break;
                    default:
                        Console.WriteLine("Unknown gender");
                        break;
                } // end switch 
            } // end WriteGender function


            int Bark(int woof)
            {
                for (int i = 0; i < woof; i++)
                {
                    Console.WriteLine("Woof!");
                    i++;
                }
                return woof;
            } // end Bark 


            void GetTag()
            {
                Console.WriteLine("If lost call {0}.", owner);
                if (puppy == Gender.Male && age > 1)
                {
                    Console.WriteLine("His name is {0}, and he is {1} years old", name, age);
                }
                if (puppy == Gender.Male && age == 1)
                {
                    Console.WriteLine("His name is {0}, and he is {1} year old", name, age);
                }
                if (puppy == Gender.Female && age > 1)
                {
                    Console.WriteLine("Her name is {0}, and she is {1} years old", name, age);
                }
                else if (puppy == Gender.Female && age == 1)
                {
                    Console.WriteLine("Her name is {0} and she is {1} year old", name, age);
                }
            } // end GetTag 

        } // end Dog

        static void Main()
        {
            puppy.Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

        } // end main 

} // end class Dog 

}
