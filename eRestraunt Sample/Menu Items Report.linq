<Query Kind="Expression">
  <Connection>
    <ID>d99f4565-c11b-487b-a960-1c53020262a7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// This Query is for pulling data to be used in a
// Details report. The query gets all the menu items
// and their categories, sorting them by the category
// description and then by the menu item description.
from cat in Items
orderby cat.MenuCategory.Description, cat.Description
select new
{
	CategoryDescription = cat.MenuCategory.Description,
	ItemDescription = cat.Description,
	Price = cat.CurrentPrice,
	Calories = cat.Calories,
	Comment = cat.Comment
}