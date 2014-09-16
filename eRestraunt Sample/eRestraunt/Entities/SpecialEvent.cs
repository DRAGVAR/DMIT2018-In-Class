using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Usings
    using System.ComponentModel.DataAnnotations;
#endregion

namespace eRestraunt.Entities
{
    #region SpecialEvent
    public class SpecialEvent
    {
        [Key]
        public string EventCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        #region Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion
    }
    #endregion
}
