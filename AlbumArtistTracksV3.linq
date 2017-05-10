<Query Kind="Statements">
  <Connection>
    <ID>513b0a51-c08e-4bee-b821-f3f94de2a678</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in MediaTypes
			select new
			{
				Name=g.Name,
				Tracks=from t in g.Tracks
						select new
				{	
					TrackName=t.Name,
					Album=t.Album.Title,
					Genre=t.Genre.Name,
					Artist=t.Album.Artist.Name,
					ReleaseYear=t.Album.ReleaseYear,
					ReleaseLabel=t.Album.ReleaseLabel
					
				}
			};
results.Dump();