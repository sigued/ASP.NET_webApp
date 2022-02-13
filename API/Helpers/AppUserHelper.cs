
using API.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API.Helpers
{
    public static class AppUserHelper
    {
        public static async Task<bool> UserExists(string username, DataContext context)
        {
            return await context.Users.AnyAsync( x => x.UserName == username.ToLower());
        }
    }
}
