namespace Lesson16
{
    public class ElectionsManegment
    {
        public Dictionary<string, int> Votes = new();
        public ElectionsManegment()
        {
        }

        public void CreateTopic(string name)
        {
            Console.WriteLine("Enter name of the topic:");
            name = Console.ReadLine();
        }

        public void CreateOptions(string name)
        {
            name = Console.ReadLine();
            Votes.Add(name, 0);
        }

    }

    public class Vote : ElectionsManegment
    {
        public Vote()
        {

        }
      
        public void VoteFor(string optionName)
        {
            if(Votes.ContainsKey(optionName))
            {
                Votes[optionName] += 1;
            }
            else
            {
                Console.WriteLine("You are invalid)))");
            }
        }
    }

    class Programe
    {
        static void Main(string[] args)
        {

        }
    }
}