namespace distans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console************************
            //Console- found in "System" namespace.
            //allwos for interaction with console.
            //Commonly used methoods: WriteLine(), ReadLine(), Clear()
           


            //MATH ************
            //Math - found in "system" namespace
            //Provides mathematical functions
            //Commonly used methoods: Math.Abs(), Math, Floor(), Math.ceiling


            //Random****************************
            //Random - found in "system" namespace
            //Generate random numbers
            //Commonly used methoods: Random.Next(), Random.NextDouble()


            //DataTime*********************************
            //DataTime- found in "System" namespace
            //Used to represent dates and times
            //can be used to fetch the current date and time with "DateTime.Now(()" or to creat a speciafic date/time objects.
            
            Console.WriteLine("Enter a datefor an event");
            string event1 = Console.ReadLine(); 
            Console.WriteLine($"Remember: {event1}on {DateTime.Now.DayOfWeek}");






            //String *******************************
            //found in "system" namespace
            //Represents a sequensces of characters
            //Contains many methoods for string mainpulation like: SubString(), IndexOf(), Relpace(), ToLower()


            Console.WriteLine("Enter a sentence or a word");
            string sentence = Console.ReadLine();
            char[] charArray = sentence.ToCharArray();

           Array.Reverse( charArray );
           Console.WriteLine($"The sentenced revered is : {new string (charArray)}");

            //string sentence = "Fuck You";
            bool contatinsBadWord= sentence.Contains("Fuck ");



            //Array************'
            //Found in "system" Namespace
            //Provides methoods fro creating, manipulating and searching Arrays.
            double[] numbers = new double[5];
        for ( int i = 0; i < numbers.Length; i++ )
            {
                Console.WriteLine($" Enter number {i + 1}");
                numbers[i] = double.Parse (Console.ReadLine()); 

            }
            Console.WriteLine(" The numbers you entered int reversed order is the following: ");
            for ( int i = 4;i >= 0;i-- )
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}