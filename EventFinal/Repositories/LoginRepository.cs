using EventFinal.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace EventFinal.Repositories
{
    public class LoginRepository: BaseRepository,ILoginRepository
    {
        public LoginRepository(IConfiguration configuration) : base(configuration)
        { }
        public Registration Login(string Username, string Password)
        {
            var query = @"EXEC" + DBConstant.Login + "@Username,@Password";
            using (var connection = Connect())
            {
                Registration registration = connection.QuerySingle<Registration>(query, new { Username, Password });
                return registration;
            }
        }
    }
}
