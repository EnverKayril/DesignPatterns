using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnocuncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        AppDbContext _context = new AppDbContext();

        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            _context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim derginiz kargoya verildi"
            });
            _context.SaveChanges();
        }
    }
}
