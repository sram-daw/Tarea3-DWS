namespace RamiloAlonsoSaraTarea3.Models
{
    public class LoginManager : IDisposable

    {
        private readonly LoginsContext _context;

        public LoginManager(LoginsContext context)
        {
            _context = context;
        }

        public Logins GetLoginByUserPwd(string user, string pwd)
        {
            return (Logins)_context.Logins.FirstOrDefault(login => login.Username == user && login.Password == pwd);
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
