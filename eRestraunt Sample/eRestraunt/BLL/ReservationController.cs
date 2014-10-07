using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Usings
using System.ComponentModel;
using eRestraunt.Entities;
using eRestraunt.DAL;
using System.Data.Entity;
using eRestraunt.Entities.DTOs; // Needed for the Lambda version of the Include() method
#endregion

namespace eRestraunt.BLL
{
    #region ReservationController
    [DataObject]
    public class ReservationController
    {
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
        public List<Reservation> ListAllReservations()
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Reservations.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> ListReservationsBySpecialEvent(String EventID)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                var result = from ReservationsBySpecialEvent in context.Reservations
                             where ReservationsBySpecialEvent.EventCode == EventID
                             select ReservationsBySpecialEvent;

                return result.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Reservation GetReservation(int reservationID)
        {
            using (RestrauntContext context = new RestrauntContext())
            {
                return context.Reservations.Find(reservationID);
            }
        }
        #endregion
        #endregion
    }
    #endregion
}
