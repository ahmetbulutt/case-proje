//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFinancialCrmm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banks
    {
        public Banks()
        {
            this.BankProcesses = new HashSet<BankProcesses>();
        }
    
        public int BankId { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankTitle { get; set; }
        public Nullable<decimal> BankBalance { get; set; }
    
        public virtual ICollection<BankProcesses> BankProcesses { get; set; }
    }
}
