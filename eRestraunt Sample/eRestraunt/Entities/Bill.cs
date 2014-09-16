using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestraunt.Entities
{
    #region Bill
    public class Bill
    {
        public DateTime BillDate { get; set; }
        public DateTime OrderPlaced { get; set; }
        public int NumberInParty { get; set; }
        public bool PaidStatus { get; set; }
        public int WaiterID { get; set; }
        public int TableID { get; set; }
        public int ReservationID { get; set; }
        public bool OrderReady { get; set; }
        public string Comment { get; set; }

        #region Navigation Properties
        public virtual ICollection<BillItem> BillItems { get; set; }
        #endregion
    }
    #endregion
}
