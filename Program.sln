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

        Dog puppy = new Dog();

        static void PrintGender(Gender gender)
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
        } // end PrintGender function


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
            Console.WriteLine("If lost call {0}.", Owner); 
            if (puppy == Gender.Male && Age > 1) 
            {
                Console.WriteLine("His name is {0}, and he is {1} years old", Name, Age); 
            }
            if (puppy == Gender.Male && Age == 1)
            {
                Console.WriteLine("His name is {0}, and he is {1} year old", Name, Age);
            }
            if (puppy == Gender.Female && Age > 1)
            {
                Console.WriteLine("Her name is {0}, and she is {1} years old", Name, Age);
            }
            else if (puppy == Gender.Female && Age == 1) 
            {
                Console.WriteLine("Her name is {0} and she is {1} year old", Name, Age); 
            }
        } // end GetTag 

        static void Main()
        {
            puppy.Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

        } // end main 

} // end class Dog 

}
