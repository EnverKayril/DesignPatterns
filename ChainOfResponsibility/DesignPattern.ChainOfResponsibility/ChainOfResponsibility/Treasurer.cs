using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            AppDbContext appDbContext = new AppDbContext();
            if (request.Amount <= 100000 )
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Treasurer - Ayşe Çınar";
                customerProcess.Description = "Ödeme işlemi onaylandı.";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Treasurer - Ayşe Çınar";
                customerProcess.Description = "Para çekme tutarı veznedarın günlük ödeyebileceği limiti aştığı için, işlem Şube Müdür Yardımcısına yönlendirildi";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}