namespace Atm.Atm
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("(1) Uygulamaya giriş yapmak için Lütfen tıklayınız: ");
            int secim = int.Parse(Console.ReadLine());

            Database database = new Database();
            switch (secim)
            {
                case 1:
                    LoginAccount.Login(Database.userlist);
                    break;
                
            }

        }
            
    }
}