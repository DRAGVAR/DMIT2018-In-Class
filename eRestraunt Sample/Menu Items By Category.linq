<Query Kind="Expression">
  <Connection>
    <ID>79b7c5a2-3b34-4af0-ab79-6a698cbd8c06</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from cat in MenuCategories
orderby cat.Description
select new
{
	Description = cat.Description,
	MenuItems = from item in cat.Items
		where item.Active
		orderby item.Description
		select new
		{
			Description = item.Description,
			Price = item.CurrentPrice,
			Calories = item.Calories,
			Comment = item.Comment
		}
}