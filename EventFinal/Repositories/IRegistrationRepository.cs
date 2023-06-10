using EventFinal.Models;
namespace EventFinal.Repositories
{
    public interface IRegistrationRepository
    {
        bool AddRegistration(Registration register);
    }
}
