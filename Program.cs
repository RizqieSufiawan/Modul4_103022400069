namespace Modul4_103022400069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePaket kodePaket = new KodePaket();

            Console.WriteLine("Basic Package: " + kodePaket.GetKodePaket("Basic"));
            Console.WriteLine("Standard Package: " + kodePaket.GetKodePaket("Standard"));
            Console.WriteLine("Premium Package: " + kodePaket.GetKodePaket("Premium")); 
            Console.WriteLine("Unlimited Package: " + kodePaket.GetKodePaket("Unlimited")); 
            Console.WriteLine("Gaming Package: " + kodePaket.GetKodePaket("Gaming"));
            Console.WriteLine("Streaming Package: " + kodePaket.GetKodePaket("Streaming"));
            Console.WriteLine("Family Package: " + kodePaket.GetKodePaket("Family"));
            Console.WriteLine("Business Package: " + kodePaket.GetKodePaket("Business"));
            Console.WriteLine("Student Package: " + kodePaket.GetKodePaket("Student"));
            Console.WriteLine("Traveler Package: " + kodePaket.GetKodePaket("Traveler"));

            MesinKopi mesinKopi = new MesinKopi();
            mesinKopi.Standby();
            mesinKopi.Brewing();
            mesinKopi.Standby();
            mesinKopi.Maintenance();
            mesinKopi.Standby();
            mesinKopi.Off();
            mesinKopi.Maintenance();
        }
    }
}
