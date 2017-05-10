<Query Kind="Statements">
  <Connection>
    <ID>513b0a51-c08e-4bee-b821-f3f94de2a678</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results=from x in Artists
			where x.ArtistId == 1
			orderby x.Name 
			select new 
			{
				
				Artist=x.Name,
				Albums=from t in x.Albums
						orderby t.Title
						select new
				{
					Title=t.Title,
					Tracks =from tr in t.Tracks
							select new
					{
						TrackName= tr.Name,
						Genre=tr.Genre.Name,
						MediaType=tr.MediaType.Name,
						Composer=tr.Composer,
						Milliseconds=tr.Milliseconds
					}
				}
			};
results.Dump();