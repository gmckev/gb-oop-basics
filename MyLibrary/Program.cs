namespace MyLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var building = Creator.CreateBuilding();
            var building2 = Creator.CreateBuilding(5, 5, 20, 2);
            Console.WriteLine(building2.UniqueNumber);
            Console.ReadKey();
        }
    }
}
