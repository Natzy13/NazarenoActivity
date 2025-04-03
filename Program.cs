namespace Nazareno_Activity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSub = 0;
            float average = 0f, sum = 0f;
           
            Console.Write("Please Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of subjects you are currently taking: ");
            numSub = Convert.ToInt32(Console.ReadLine());
            
            string[] subjects = new string[numSub]; //Array for subjects
            float[] grades = new float[numSub];     //Array for grades

            for (int i = 0; i < subjects.Length; i++) 
            {
                Console.Write("Enter Subject Number "+ (i+1)+": ");
                string subName = Console.ReadLine();
                subjects[i] = subName;              
            }

            Console.WriteLine(" ");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.Write("Enter grade for " + subjects[i] + " subject: ");
                float gradeInput = Convert.ToInt16(Console.ReadLine());
                grades[i] = gradeInput;
            }

            foreach (int grade in grades)
            {
                sum += grade;
                average = (sum/(numSub*100)*100);
            }

            Console.WriteLine("\nYour Final Average is: "+ average);
        }
    }
}
