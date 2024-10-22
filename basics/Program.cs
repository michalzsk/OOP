namespace basics
{
    internal class Program
    {
        public class group
        {
            public string name;
            public int count;
            public string mainteacher;
            public string[] students;
        }
        static void Main(string[] args)
        {
            group PiataC= new group();
            PiataC.name = "5C";
            PiataC.count = 20;
            PiataC.mainteacher = "Obstalecka";
            PiataC.students = new string[PiataC.count];
            group PiataA = new group();
            PiataA.name = "5A";
            PiataA.count = 25;
            PiataA.mainteacher = "Radar";
            PiataA.students = new string[PiataA.count];
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                int rnd = random.Next(0, 2);
                if (rnd == 1)
                {
                    Console.WriteLine(rnd);
                    Console.WriteLine("wygrywa" + PiataC.mainteacher);
                }
                else
                {
                    Console.WriteLine(rnd);
                    Console.WriteLine("wygrywa" + PiataA.mainteacher);
                }
            }
            string[] pkn = new string[3] { "papier", "kamien", "nozyce" };
            bool isFight = true;
            while (isFight)
            {
                int rnd2 = random.Next(0, 2);
                int rnd3 = random.Next(0, 2);
                Console.WriteLine(PiataC.mainteacher + " zagrywa "+ pkn[rnd2]);
                Console.WriteLine(PiataA.mainteacher + " zagrywa " + pkn[rnd3]);
                if (rnd2 == rnd3)
                {
                    Console.WriteLine("remis");
                }else if(rnd2==0 && rnd3==1 || rnd2==1 && rnd3==2 || rnd2==2 && rnd3 == 0)
                {
                    Console.WriteLine("wygrywa "+ PiataC.mainteacher);
                    isFight = false;
                }
                else
                {
                    Console.WriteLine("wygrywa " + PiataA.mainteacher);
                    isFight = false;
                }

            }

        }
    }
}
