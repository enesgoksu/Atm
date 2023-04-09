namespace Atm.Atm
{
    class Database
    {
        public static List<Users> userlist = new List<Users>();
        public Database()
        {
            Users user1 = new Users{Name = "Enes",Surname = "Göksu",Idno = "123456",Password = "123654",Balance = 500};
            Users user2 = new Users{Name = "Arda",Surname = "Güler",Idno = "123789",Password = "147852",Balance = 1500};
            Users user3 = new Users{Name = "Volkan",Surname = "Demirel",Idno = "123654",Password = "369852",Balance = 250};

            userlist.Add(user1);
            userlist.Add(user2);
            userlist.Add(user3);
        }
        
    }
}