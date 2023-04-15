namespace DZ_CS_12
{
    internal class Play:IDisposable
    {
        public string? playName{  get; private set; }
        public string? authorsName { get; private set; }
        public string? genre { get; private set; }
        public int?    yearOfCreate { get; private set; }
        public int id;
        public Play()
        {
            this.playName     = null;
            this.authorsName  = null;
            this.genre        = null;
            this.yearOfCreate = null;
        }
        public Play(string PlayName, string AythorsName, string Genre, int YearOfCreate, int Id)
        {
            playName     = PlayName;
            authorsName  = AythorsName;
            genre        = Genre;
            yearOfCreate = YearOfCreate;
            id           = Id;
        }

        public void InputData()
        {
            Console.WriteLine("Enter the name of play:");
            playName = Console.ReadLine();

            Console.WriteLine("Enter the authors name:");
            authorsName = Console.ReadLine();

            Console.WriteLine("Enter the genre of play:");
            genre = Console.ReadLine();

            Console.WriteLine("Enter the year of creation:");
            yearOfCreate = Convert.ToInt32(Console.ReadLine());


        }
        public override string ToString()
        {
            return $"Play name:\t{playName}\nAuthor:\t\t{authorsName}\nGenre:\t\t{genre}\nYear:\t\t{yearOfCreate}\n";
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine($"Play {id} was destroyed with Dispose method!");
            Console.Beep();
        }

        ~Play()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Play object was destroyed:\t" + this.id);
            Console.Beep();
        }
    }
}
