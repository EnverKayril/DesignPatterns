using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            AppDbContext appDbContext = new AppDbContext();
            if (request.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Murat Öztürk";
                customerProcess.Description = "Ödeme işlemi onaylandı.";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Murat Öztürk";
                customerProcess.Description = "Para çekme tutarı Şube Müdür Yardımcısının günlük ödeyebileceği limiti aştığı için, işlem Şube Müdürüne yönlendirildi";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
