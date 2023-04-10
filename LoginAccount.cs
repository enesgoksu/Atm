namespace Atm.Atm
{
    class LoginAccount
    {
        public static void Login(List<Users> userlist)
        {   
            Console.Write("Lütfen kullanıcı id numaranızı girin: ");
            string idno = Console.ReadLine();
            Console.Write("Lütfen parolanızı girin: ");
            string password = Console.ReadLine();
            bool control = true;

            foreach (Users user in userlist)
            {
                while (control)
                {
                    
                
                    if (idno == user.Idno && password == user.Password)
                    {
                        Console.WriteLine("(1) Bakiye Görüntüleme");
                        Console.WriteLine("(2) Para Çekme");
                        Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
                        int secim = int.Parse(Console.ReadLine());
                        int kalanTutar;
                        control = false;

                        if (secim == 1)
                        {
                            Console.WriteLine(user.Name+" "+"Bakiyeniz: "+ user.Balance);
                        }
                        else if (secim == 2)
                        {
                            Console.Write("Çekmek istediğiniz tutarı girin: ");
                            int tutar = int.Parse(Console.ReadLine());
                            kalanTutar = user.Balance - tutar; 
                            if (tutar <= user.Balance)
                            {
                                Console.WriteLine("Kalan bakiyeniz: "+ kalanTutar);
                                control = false;
                            }
                            else if (tutar > user.Balance)
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen bilgilerinizi kontrol ediniz.");
                        control = false;
                        
                    }
                }
            }
        }
    }
}