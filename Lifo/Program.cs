namespace Lifo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            USet halmaz = new USet(7);
            halmaz.Push("pirike");
            halmaz.Push("jozep");
            halmaz.Push("asdg");
            halmaz.Push("asdg");
            halmaz.Push("ghggg");
            Console.WriteLine(halmaz.ToString());

        }
    }
}
