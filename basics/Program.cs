namespace basics
{
    internal class Program
    {
        public class Group(string name, int count, string mainTeacher, string[] students)
        {
            public string name { get; private set; } = name;
            public int count { get; private set; } = count;
            public string mainTeacher { get; private set; } = mainTeacher;
            public string[] students { get; private set; } = students;
        }
        static void Main(string[] args)
        {
            Group g1 = new Group("5c", 20, "Obstalecka", new string[20]);
            Group g2 = new Group("5a", 22, "Radar", new string[22]);

            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                int rnd = random.Next(0, 2);
                if (rnd == 1)
                {
                    Console.WriteLine(rnd);
                    Console.WriteLine("wygrywa" + g1.mainTeacher);
                }
                else
                {
                    Console.WriteLine(rnd);
                    Console.WriteLine("wygrywa" + g2.mainTeacher);
                }
            }
            string[] pkn = new string[3] { "papier", "kamien", "nozyce" };
            bool isFight = true;
            while (isFight)
            {
                int rnd2 = random.Next(0, 2);
                int rnd3 = random.Next(0, 2);
                Console.WriteLine(g1.mainTeacher + " zagrywa "+ pkn[rnd2]);
                Console.WriteLine(g2.mainTeacher + " zagrywa " + pkn[rnd3]);
                if (rnd2 == rnd3)
                {
                    Console.WriteLine("remis");
                }else if(rnd2==0 && rnd3==1 || rnd2==1 && rnd3==2 || rnd2==2 && rnd3 == 0)
                {
                    Console.WriteLine("wygrywa "+ g1.mainTeacher);
                    isFight = false;
                }
                else
                {
                    Console.WriteLine("wygrywa " + g2.mainTeacher);
                    isFight = false;
                }

            }

        }
    }
}
