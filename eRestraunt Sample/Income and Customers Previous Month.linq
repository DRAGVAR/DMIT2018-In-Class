<Query Kind="Statements">
  <Connection>
    <ID>6f556599-072a-4e8f-95da-cec1ee0a3c41</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Get the following from the Bills table for a given month/year:
// BillDate, ID, # people served, total amount billed
// Then, display the total income for the month and the number of customers served

// 0) Set up info that might be passed in to my BLL
var month = DateTime.Today.Month - 1; // previous month
var year = DateTime.Today.Year;		  // current year

// 1) Get the Bill data for the month/year with a sum of each Bill's BillItems
var billsInMonth = 	from item in Bills
					where item.PaidStatus // Only the bills that were/are paid
						&& item.BillDate.Month == month
						&& item.BillDate.Year == year
					orderby item.BillDate
				   	select new
				   	{
				   		BillDate = item.BillDate,
						BillId = item.BillID,
						NumberOfCustomers = item.NumberInParty,
						TotalAmount = item.BillItems.Sum(bi => bi.Quantity * bi.SalePrice)
				   	};
// billsInMonth.Dump();

// Temp: some variables for formatting
var monthName = DateTime.Today.AddMonths(-1).ToString("MMMM");
var title = string.Format("Total income for {0} {1}", monthName, year);

// Temp: Perform some quick aggregates to check my query
billsInMonth.Sum(tm => tm.TotalAmount).ToString("C").Dump(title, true);

billsInMonth.Sum(tm => tm.NumberOfCustomers).Dump("Patrons Served", true);

// 2) Build a report from the billsInMonth data
var report = from item in billsInMonth
			 group item by item.BillDate.Day into dailySummary
			 select new
			 {
			 	Day = dailySummary.Key,
				DailyCustomers = dailySummary.Sum(grp => grp.NumberOfCustomers),
				Income = dailySummary.Sum(grp => grp.TotalAmount)
			 };
report.OrderBy(r => r.Day).Dump("Daily Income");















