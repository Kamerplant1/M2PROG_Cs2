namespace _4Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[] { 0.99, 5.60, 10.11 };
            string[] artikelen = { "snoepje", "luxe broodje","lunch menu" };
            Formulier[] formulieren = new Formulier[2];
        }
    }
}
internal class Formulier
{
    internal int sterren { get; set; }
    internal string Feedback { get; set; }
}
