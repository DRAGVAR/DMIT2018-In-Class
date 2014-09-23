using eRestraunt.DAL;
using eRestraunt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Usings
    using System.ComponentModel;
#endregion

namespace eRestraunt.BLL
{
    [DataObject]
    public class RestrauntAdminController
    {
        #region Manage Waiters
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddWaiter(Waiter item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                // TODO: Validation of waiter data...
                var added = context.Waiters.Add(item);
                context.SaveChanges();
                return added.WaiterID;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateWaiter(Waiter item) 
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                // TODO: Validation
                var attatched = context.Waiters.Attach(item);
                var matchingWithExistingValues = context.Entry<Waiter>(attatched);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteWaiter(Waiter item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                var existing = context.Waiters.Find(item.WaiterID);
                context.Waiters.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Waiter> ListAllWaiters()
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Waiters.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Waiter GetWaiter(int waiterID)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Waiters.Find(waiterID);
            }
        }
        #endregion
        #endregion

        #region Manage Tables
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddTable(Table item)
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateTable(Table item)
        {
        }

        public void DeleteTable(Table item)
        {
        }
        #endregion
        #region Query
        public List<Table> ListAllTables()
        {
            throw new NotImplementedException();
        }

        public Table GetTable(int tableID)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion

        #region Manage Items
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddItem(Item item)
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateItem(Item item)
        {
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteItem(Item item)
        {
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Item> ListAllItems()
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Item GetItem(int itemID)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion

        #region Manage Special Events
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddSpecialEvent(SpecialEvent item)
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateSpecialEvent(SpecialEvent item)
        {
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteSpecialEvent(SpecialEvent item)
        {
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListAllSpecialEvents()
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent GetSpecialEvent(int specialeventID)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
