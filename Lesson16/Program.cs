namespace Lesson16
{
    public class ElectionsManegment
    {
        public Dictionary<string, int> Votes = new();
        string topicName;
        public ElectionsManegment()
        {
        }

        public void CreateTopic(string name)
        {
            topicName = name;
        }

        public void CreateOptions()
        {
            string name = Console.ReadLine();
            if (name != "stop")
            {
                Votes.Add(name, 0);
                CreateOptions();
            }
        }

        public void VoteFor(string optionName)
        {
            if (Votes.ContainsKey(optionName))
            {
                Votes[optionName] += 1;
            }
            else
            {
                Console.WriteLine("You are invalid)))");
            }
        }
    }


    public class UserInterface
    {
        ElectionsManegment electionsManegment = new ElectionsManegment();


        public void Inerface()
        {
            Console.WriteLine("Enter your variant");

            Console.WriteLine("1.Start new election");
            Console.WriteLine("2.Vote");
            Console.WriteLine("3.Show results");

            int i = int.Parse(Console.ReadLine());

            switch(i)
            {
                case 1:
                    Console.WriteLine("Enter topic of election:");
                    string name = Console.ReadLine();
                    electionsManegment.CreateTopic(name);
                    Console.WriteLine("Enter options:(if you want to stop entering options, enter stop)");
                    electionsManegment.CreateOptions();
                    break;
                case 2:
                    Console.WriteLine("Choose variant");
                    Console.WriteLine("Enter name of candidat");

                    string nameOfCandidat = Console.ReadLine();
                    if(electionsManegment.Votes.ContainsKey(nameOfCandidat))
                    {
                        electionsManegment.VoteFor(nameOfCandidat);
                    }
                    else
                    {
                        Console.WriteLine("You are invalid");
                    }
                    break;
                case 3:
                    foreach(var item in electionsManegment.Votes)
                    {
                        Console.WriteLine($"{item.Key}, {item.Value}");
                    }
                    break;
            }
        }
        
    }
    class Programe
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();

            while(true)
            {
                userInterface.Inerface();
            }
        }
    }
}