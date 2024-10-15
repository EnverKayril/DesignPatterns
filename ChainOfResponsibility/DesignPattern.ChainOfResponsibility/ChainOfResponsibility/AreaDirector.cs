using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            AppDbContext appDbContext = new AppDbContext();
            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Kaya Yarım";
                customerProcess.Description = "Ödeme işlemi onaylandı.";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Kaya Yarım";
                customerProcess.Description = "Para çekme tutarı Bölge Müdürünün günlük ödeyebileceği limiti aştığı için, işlem gerçekleştirilemedi.";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();
            }
        }
    }
}
