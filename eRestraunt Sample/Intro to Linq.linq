<Query Kind="Statements">
  <Connection>
    <ID>8cb4067a-8b7f-49f7-95ab-8e19323d479e</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

/* Example 1: Querying data from eRestaurant */
var result = from row in Tables
						where row.Capacity > 3
						select row;

// The following line won't work in your VS project....
result.Dump(); //The .Dump() method is an extension method in LinqPad - it's not in .NET

/* Example 2: Query a simple array of strings */
string[] names = {"Dan", "Don", "Sam", "Dwayne", "Laurel", "Steve"};
names.Dump();

var shortlist = from person in names
				where person.StartsWith("D")
				select person;
shortlist.Dump();

/* Example 3: Find the most recent Bill and its total */
// Get all the bills that have been placed
var allBills = from thingy in Bills
			   where thingy.OrderPlaced.HasValue
			   select new // Declaring an "anonymous type" on-the-fly
			   { 		  // Using an initializer list to set the properties
			   	   BillDate = thingy.BillDate,
				   IsReady = thingy.OrderReady
			   };
allBills.Count().Dump(); // Show the count of items
allBills.Take(5).Dump(); // Show the first 5 bills