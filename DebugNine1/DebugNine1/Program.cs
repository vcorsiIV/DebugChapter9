// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for infromation about two courses
using static System.Console;

namespace DebugNine1
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeworkAssignment course1 = new HomeworkAssignment();
            HomeworkAssignment course2 = new HomeworkAssignment();
            string entryString;
            int exercises;

            // Get info for first class
            Write("What class do you have homework for? ");
            //entryString not entry
            entryString = ReadLine();
            //className to ClassName()
            course1.ClassName = entryString;
            Write("How many exercises must you complete? ");
            entryString = ReadLine();
            //exercises requires an 'out' to work
            int.TryParse(entryString, out exercises);
            //exercises should set the value of course1.NumberOfExercises not the other way around
            course1.NumberOfExercises = exercises;

            // Get info for another class
            Write("What class do you have homework for? ");
            entryString = ReadLine();
            //Repeat as above
            course2.ClassName = entryString;
            Write("How many exercises must you complete? ");
            entryString = ReadLine();
            //int.TryParse not char.TryParse
            int.TryParse(entryString, out exercises);
            course2.NumberOfExercises = exercises;

            WriteLine("You have {0} minutes of homework for {1}",
                  course1.timeToComplete, course1.ClassName);
            WriteLine("and {0} more minutes for {1}",
                  course2.timeToComplete, course2.ClassName);
        }

        class HomeworkAssignment
        {
            private int numberOfExercises;
            //adding a private string
            private string className;
            //trying with public int
            public int timeToComplete;
            // 10 minutes to complete each exercise
            private const int TIME_PER_EXERCISE = 10;
            public string ClassName
            {
                get
                {
                    return className;
                }
                set
                {
                    className = value;
                }
            }

            public int NumberOfExercises
            {
                get
                {
                    //numberOfExercises
                    return numberOfExercises;
                }
                set
                {
                    //Value is used not number
                    numberOfExercises = value;
                    CalcCompletionTime();
                }
            }
            public double TimeToComplete
            {
                get
                {
                    return timeToComplete;
                }
            }
            private void CalcCompletionTime()
            {
                timeToComplete = numberOfExercises * TIME_PER_EXERCISE;
            }
        }
    }
}
