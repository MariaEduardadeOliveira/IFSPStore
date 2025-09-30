using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    internal class User : BaseEntity<int>
    {
        public User(int id, string name, string password, string login, string email, DateTime registerDate, DateTime loginDate, bool active):base(id)
        {
            Name = name;
            Password = password;
            Login = login;
            Email = email;
            RegisterDate = registerDate;
            LoginDate = loginDate;
            Active = active;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LoginDate { get; set; }
        public bool Active { get; set; }
    }
}
