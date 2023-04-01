using Inventory_tracking_basic.Models;

namespace Inventory_tracking_basic.Services
{
    public interface IRepository
    {
        public User Auth(LoginModel login);
        public void Register(LoginModel login);
        public User Get(string email);
    }
}
