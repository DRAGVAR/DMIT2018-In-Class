<Query Kind="Program">
  <Connection>
    <ID>c70f641a-e90c-44d2-adc1-160b98a9ad47</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

void Main()
{
	var date = new DateTime(2014, 10, 24);
	date.Dump();
	ReservationsByTime(date).Dump();
}

// Define other methods and classes here
public List<dynamic> ReservationsByTime(DateTime date)
{
	var result = from data in Reservations
				 where data.ReservationDate.Year == date.Year
				 	&& data.ReservationDate.Month == date.Month
					&& data.ReservationDate.Day == date.Day
					&& data.ReservationStatus == 'B' //Reservation.Booked
				 select new // DTOs.ReservationSummary()
				  {
				  	  Name = data.CustomerName,
					  Date = data.ReservationDate,
					  NumberInParty = data.NumberInParty,
					  Status = data.ReservationStatus,
					  Event = data.SpecialEvents.Description,
					  Contact = data.ContactPhone,
					  Tables = from seat in data.ReservationTables
					  		   select seat.Table.TableNumber
				  };
	  var finalResult = from item in result
	  					group item by item.Date.TimeOfDay;
	  return finalResult.ToList<dynamic>();
}