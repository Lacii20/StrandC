
namespace StrandC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furdo> list = new List<Furdo>();
            string[] sorok = File.ReadAllLines("strandadatok.txt").Skip(1).ToArray();
            foreach (string s in sorok) {
                list.Add(new Furdo(s));             
            }
            Console.WriteLine("7 feladat:");
            Console.WriteLine($"Fűrdők száma : {list.Count}");

        }
    }
}
