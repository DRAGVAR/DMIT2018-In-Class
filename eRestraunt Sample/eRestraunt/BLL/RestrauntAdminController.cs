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
            {
                using (RestrauntContext context = new RestrauntContext())
                {
                    // TODO: Validation of Table data....
                    var added = context.Tables.Add(item);
                    context.SaveChanges();
                    return added.TableID;
                }
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateTable(Table item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                // TODO: Validation
                var attached = context.Tables.Attach(item);
                var matchingWithExistingValues = context.Entry<Table>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteTable(Table item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                var existing = context.Tables.Find(item.TableID);
                context.Tables.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        public List<Table> ListAllTables()
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Tables.ToList();
            }
        }

        public Table GetTable(int TableID)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Tables.Find(TableID);
            }
        }
        #endregion
        #endregion

        #region Manage Items
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddItem(Item item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                // TODO: Validation of Item data....
                var added = context.Items.Add(item);
                context.SaveChanges();
                return added.ItemID;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateItem(Item item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                // TODO: Validation
                var attached = context.Items.Attach(item);
                var matchingWithExistingValues = context.Entry<Item>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteItem(Item item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                var existing = context.Items.Find(item.ItemID);
                context.Items.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Item> ListAllItems()
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Items.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Item GetItem(int itemID)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Items.Find(itemID);
            }
        }
        #endregion
        #endregion

        #region Manage Special Events
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddSpecialEvent(SpecialEvent item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                // TODO: Validation of SpecialEvent data....
                var added = context.SpecialEvents.Add(item);
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateSpecialEvent(SpecialEvent item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                // TODO: Validation
                var attached = context.SpecialEvents.Attach(item);
                var matchingWithExistingValues = context.Entry<SpecialEvent>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteSpecialEvent(SpecialEvent item)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                var existing = context.SpecialEvents.Find(item.EventCode);
                context.SpecialEvents.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListAllSpecialEvents()
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.SpecialEvents.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent GetSpecialEvent(int specialeventID)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.SpecialEvents.Find(specialeventID);
            }
        }
        #endregion
        #endregion
    }
}
