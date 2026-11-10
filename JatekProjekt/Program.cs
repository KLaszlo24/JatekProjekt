namespace JatekProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                var dbKezelo = new AdatbazisKezelo();
                var karakterek = dbKezelo.AdatokBetoltese();
                foreach (var item in karakterek)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
