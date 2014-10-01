using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Usings
using System.ComponentModel;
using eRestraunt.Entities;
using eRestraunt.DAL;
using System.Data.Entity; // Needed for the Lambda version of the Include() method
#endregion

namespace eRestraunt.BLL
{
    #region MenuController
    [DataObject]
    public class MenuController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Item> ListMenuItems()
        {
            using (var context = new RestrauntContext())
            {
                // Note: To use the Lambda or Method style of Include, you need to use System.Data.Entity
                // Get the Item data and include the Category data for each item
                // The .Include() method on the DBSet<T> class performs "eager loading" of data
                return context.Items.Include(it => it.Category).ToList();
            }
        }
    }
    #endregion
}
