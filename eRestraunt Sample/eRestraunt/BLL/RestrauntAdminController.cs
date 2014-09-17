using eRestraunt.DAL;
using eRestraunt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestraunt.BLL
{
    public class RestrauntAdminController
    {
        #region Manage Waiters
        #region Command
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
        public List<Waiter> ListAllWaiters()
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Waiters.ToList();
            }
        }

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
        public int AddTable(Table item)
        {
            throw new NotImplementedException();
        }

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
        public int AddItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
        }

        public void DeleteItem(Item item)
        {
        }
        #endregion
        #region Query
        public List<Item> ListAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetItem(int itemID)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion

        #region Manage Special Events
        #region Command
        public int AddSpecialEvent(SpecialEvent item)
        {
            throw new NotImplementedException();
        }

        public void UpdateSpecialEvent(SpecialEvent item)
        {
        }

        public void DeleteSpecialEvent(SpecialEvent item)
        {
        }
        #endregion
        #region Query
        public List<SpecialEvent> ListAllSpecialEvents()
        {
            throw new NotImplementedException();
        }

        public SpecialEvent GetSpecialEvent(int specialeventID)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
