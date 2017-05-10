<Query Kind="Statements">
  <Connection>
    <ID>513b0a51-c08e-4bee-b821-f3f94de2a678</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			orderby g.Name
			select new
			{
				Genre =g.Name,
				TracksCount=g.Tracks.Count()
			};
			
results.Dump("Query Math");