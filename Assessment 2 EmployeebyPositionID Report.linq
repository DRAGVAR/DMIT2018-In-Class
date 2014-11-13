<Query Kind="Statements">
  <Connection>
    <ID>b02338e8-bfb7-43b2-9375-818bf9f1eb8e</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eTools</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

var result = from info in Employees
                             where info.PositionID == 5
                             select new
							 {
							 	Description = info.Position.Description,
								Name = info.LastName + ", " + info.FirstName,
								Hired = info.DateHired,
								Release = info.DateReleased
							 };
result.Count().Dump(); // <<The total number of rows being displayed
result.Dump();