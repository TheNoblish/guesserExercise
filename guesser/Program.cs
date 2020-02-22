using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;


        static void Main(string[] args)
        {
            int trials = 0;
            List<Student> students = new List<Student>();
            Student student;
            initializeStudents();
            Random rand = new Random();
            student = students[rand.Next(students.Count)];

            /* TO DO: here is where you add your code! */
            Console.WriteLine("~ GUESS THE NAME ~");
            Console.WriteLine("In this game you have " + MaxTrials + " attempts to guess the name of a randomly selected Harry Potter Hogwarts Student. ");
            Console.WriteLine("Only first and last names included.");
            Console.WriteLine("Commonly shortened names such as Ronald will use their shortened versions.");
            Console.WriteLine("You will receive hints along the way.");
            Console.WriteLine("Press ENTER to start the game.");
            Console.ReadLine();

            while(trials < MaxTrials)
            {
                Console.WriteLine("Make a Guess");
                string guess = Console.ReadLine();

                if (guess == student.name)
                {
                    Console.WriteLine("Congratulations! You guessed the student!");
                    Console.WriteLine("Press ENTER to exit the game!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (trials >= 4)
                {
                    Console.WriteLine("Sorry, you got it wrong.");
                    char[] chars = guess.ToCharArray();
                    IEnumerable<Char> distinctChars = chars.Distinct();
                    int similarChars = 0;
                    foreach (Char ch in distinctChars)
                    {
                        if (student.name.Contains(ch))
                        {
                            similarChars++;
                        }
                    }
                    Console.WriteLine("But! There are " + similarChars + " characters that appear both in your guess and in the name!");
                    Console.WriteLine("Also! The student is a " + student.house);
                    trials++;
                }
                else
                {
                    Console.WriteLine("Sorry, you got it wrong.");
                    char[] chars = guess.ToCharArray();
                    IEnumerable<Char> distinctChars = chars.Distinct();
                    int similarChars = 0;
                    foreach (Char ch in distinctChars) 
                    {
                        if (student.name.Contains(ch))
                        {
                            similarChars++;
                        }
                    }
                    Console.WriteLine("But! There are " + similarChars + " characters that appear both in your guess and in the name!");
                    trials++;
                }


            }
            Console.WriteLine("Unfortunately you're out of tries, the student was " + student.name + " please press ENTER to exit the game");
            Console.ReadLine();
            Environment.Exit(0);

            void initializeStudents()
            {
                students.Add(new Student("Hannah Abbott","Hufflepuff" ));
                students.Add(new Student("Katie Bell", "Gryffindor"));
                students.Add(new Student("Susan Bones", "Hufflepuff"));
                students.Add(new Student("Terry Boot","Ravenclaw"));
                students.Add(new Student("Lavender Brown", "Gryffindor"));
                students.Add(new Student("Millicent Bulstrode", "Slytherin"));
                students.Add(new Student("Cho Chang", "Ravenclaw"));
                students.Add(new Student("Penelope Clearwater", "Ravenclaw"));
                students.Add(new Student("Michael Corner", "Ravenclaw"));
                students.Add(new Student("Vincent Crabbe", "Slytherin"));
                students.Add(new Student("Colin Creevey", "Gryffindor"));
                students.Add(new Student("Roger Davies", "Ravenclaw"));
                students.Add(new Student("Cedric Diggory", "Hufflepuff"));
                students.Add(new Student("Marietta Edgecombe", "Ravenclaw"));
                students.Add(new Student("Justin Finch-Fletchley", "Hufflepuff"));
                students.Add(new Student("Seamus Finnigan", "Gryffindor"));
                students.Add(new Student("Marcus Flint","Slytherin"));
                students.Add(new Student("Anthony Goldstein", "Ravenclaw"));
                students.Add(new Student("Gregory Goyle", "Slytherin"));
                students.Add(new Student("Hermione Granger", "Gryffindor"));
                students.Add(new Student("Angeline Johnson","Gryffindor"));
                students.Add(new Student("Lee Jordan","Gryffindor"));
                students.Add(new Student("Neville Longbottom","Gryffindor"));
                students.Add(new Student("Luna Lovegood","Ravenclaw"));
                students.Add(new Student("Draco Malfoy","Slytherin"));
                students.Add(new Student("Ernie Macmillan","Hufflepuff"));
                students.Add(new Student("Cormac McLaggen","Gryffindor"));
                students.Add(new Student("Graham Montague", "Slytherin"));
                students.Add(new Student("Theodore Nott","Slytherin"));
                students.Add(new Student("Pansy Parkinson","Slytherin"));
                students.Add(new Student("Padma Patil", "Ravenclaw"));
                students.Add(new Student("Parvati Patil","Gryffindor"));
                students.Add(new Student("Harry Potter", "Gryffindor"));
                students.Add(new Student("Demelza Robins","Gryffindor"));
                students.Add(new Student("Zacharias Smith","Hufflepuff"));
                students.Add(new Student("Alicia Spinnet", "Gryffindor"));
                students.Add(new Student("Dean Thomas","Gryffindor"));
                students.Add(new Student("Romilda Vane","Gryffindor"));
                students.Add(new Student("George Weasley","Gryffindor"));
                students.Add(new Student("Fred Weasley", "Gryffindor"));
                students.Add(new Student("Ginny Weasley","Gryffindor"));
                students.Add(new Student("Percy Weasley", "Gryffindor"));
                students.Add(new Student("Ron Weasley", "Gryffindor"));
                students.Add(new Student("Oliver Wood","Gryffindor"));
                students.Add(new Student("Blaise Zabini","Slytherin"));


            }
        }
    }
    class Student
    {
        public string name;
        public string house;

        public Student(string name, string house)
        {
            this.name = name;
            this.house = house;
        }
    }
}
