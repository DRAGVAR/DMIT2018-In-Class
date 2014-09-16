using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Usings
    using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace eRestraunt.Entities
{
    #region Waiters
    public class Waiter
    {
        public int WaiterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ReleaseDate { get; set; }

        #region Navigation Properties
            [NotMapped]
            public string FullName { get { return FirstName + " " + LastName; } }

            public virtual ICollection<Bill> Bills { get; set; }
        #endregion
    }
    #endregion
}
