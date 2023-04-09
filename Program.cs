namespace Atm.Atm
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Hoşgeldiniz*******");
            Console.Write("Lütfen Kullanıcı Numaranızı Girin: ");
            string idno = Console.ReadLine();
            Console.Write("Lütfen parolanızı girin: ");
            string password = Console.ReadLine();

            List<Users> userlist = new List<Users>();
            Database database = new Database();

            foreach (Users user in userlist)
            {
                if (user.Idno == idno && user.Password == password)
                {
                    Console.Write(user.Name+" "+"Hoşgeldiniz");
                    Console.WriteLine("(1) Para çekme");
                    Console.WriteLine("(2) Para Yatırma");
                    Console.WriteLine("(3) Bakiye Görüntüleme");
                    int cevap = int.Parse(Console.ReadLine());
                }
            }




            
            Console.WriteLine("(1) Para Çekme");
            Console.WriteLine("(2) Para Yatırma");
            Console.WriteLine("(3) Bakiye Görüntüle");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin");
        
        }
            
    }
}