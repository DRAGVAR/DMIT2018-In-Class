<Query Kind="Expression">
  <Connection>
    <ID>6f556599-072a-4e8f-95da-cec1ee0a3c41</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// How many customers per hour on Sept. 15th, 2014.
from info in Bills
where info.BillDate.Year == 2014
   && info.BillDate.Month == 9
   && info.BillDate.Day == 15
group info by info.BillDate.Hour into infoGroup
select new
{
    Hour = infoGroup.Key,
    CustomerBillCount = infoGroup.Count(),
    CustomersCount = infoGroup.Sum(x=>x.NumberInParty)
}