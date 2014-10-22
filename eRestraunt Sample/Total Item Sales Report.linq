<Query Kind="Statements">
  <Connection>
    <ID>6f556599-072a-4e8f-95da-cec1ee0a3c41</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Total Item Sales Report
var results = from info in BillItems
              orderby info.Item.MenuCategory.Description, info.Item.Description
              select new
              {
                    CategoryDescription = info.Item.MenuCategory.Description,
                    ItemDescription = info.Item.Description,
                    Quantity = info.Quantity,
                    Price = info.SalePrice,
                    Cost = info.UnitCost
              };
results.Count().Dump(); // <<The total number of rows being displayed
results.Dump();