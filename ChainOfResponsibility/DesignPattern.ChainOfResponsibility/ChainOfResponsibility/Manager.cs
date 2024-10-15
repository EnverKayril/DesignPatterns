using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            AppDbContext appDbContext = new AppDbContext();
            if (request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Tuğrul Sarı";
                customerProcess.Description = "Ödeme işlemi onaylandı.";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Tuğrul Sarı";
                customerProcess.Description = "Para çekme tutarı Şube Müdürünün günlük ödeyebileceği limiti aştığı için, işlem Bölge Müdürüne yönlendirildi";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
