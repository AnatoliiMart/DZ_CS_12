namespace DZ_CS_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ex1();
            //Ex2();
            Ex3();

        }
       
        static void Ex1()
        {
            CreationPlays();
            GC.Collect();
            Console.Read();
            static void CreationPlays()
            {
                Play[] plays = new Play[10];
                for (int i = 0; i < plays.Length; i++)
                {
                    plays[i] = new Play("Romeo and Julette", "William Shakespeare", "Tragedy", 1597, i);
                    Console.WriteLine(plays[i].ToString());
                }
            }
        }
        static void Ex2()
        {
            Shop[] shops = new Shop[10];
            for (int i = 0; i < shops.Length; i++)
            {
                shops[i] = new Shop("Costco", "All USA", 1, i);
                Console.WriteLine();
                Console.WriteLine(shops[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in shops)
            {
                item.Dispose();
            }
        }
        static void Ex3()
        {
            ShopDestruct();
            GC.Collect();
            Console.Read();

            Play[] plays = new Play[10];
            for (int i = 0; i < plays.Length; i++)
            {
                plays[i] = new Play("Romeo and Julette", "William Shakespeare", "Tragedy", 1597, i);
                Console.WriteLine();
                Console.WriteLine(plays[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in plays)
            {
                item.Dispose();
            }
            
            static void ShopDestruct()
            {
                Shop[] shops = new Shop[10];
                for (int i = 0; i < shops.Length; i++)
                {
                    shops[i] = new Shop("Costco", "All USA", 1, i);
                    Console.WriteLine();
                    Console.WriteLine(shops[i].ToString());
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}