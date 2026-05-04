
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
            int osszeg = 0;
            foreach (var item in list)
            {
                osszeg += item.Ár;

            }
            double átlag = osszeg / (double)list.Count;
            Console.WriteLine($"8. Feladat \r\n A Furdobelepok átlagos ára {átlag:F1} \r\n");

            Furdo min = list[0];
            foreach (var item in list)
            {
                if (item.Vizhőfok < min.Vizhőfok)
                {
                    min = item;
                }
                Console.WriteLine($"9. Feladat");
                Console.WriteLine($"A leghidegebb  víz a(z) {min.Név} nevű fürdöben van \r\n");
            }
        }
    }
}
