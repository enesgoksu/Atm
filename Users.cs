namespace Atm.Atm
{
    class Users
    {
        private string name;
        private string surname;
        private string idno;
        private string password;
        private double balance;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Idno { get => idno; set => idno = value; }
    
        public string Password { get => password; set => password = value; }
        public double Balance { get => balance; set => balance = value; }
    }
}