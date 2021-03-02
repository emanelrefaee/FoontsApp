namespace API.entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordKey { get; set; }

        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
    }
}