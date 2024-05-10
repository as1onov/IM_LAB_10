using Lab10.FootballManager.Models;
using System.Collections.Generic;

namespace Lab10.FootballManager.Data
{
	public static class GameData
	{
		public static List<Team> Teams { get; set; } = new List<Team>()
		{
			new Team { Name = "Liverpool", Lambda = 2.1 },
			new Team { Name = "Manchester City", Lambda = 2.2 },
			new Team { Name = "Barcelona", Lambda = 2.0 },
			new Team { Name = "Real Madrid", Lambda = 1.9 },
			new Team { Name = "Bayern Munich", Lambda = 1.8 },
			new Team { Name = "Juventus", Lambda = 1.7 },
			new Team { Name = "Paris Saint-Germain", Lambda = 2.3 },
			new Team { Name = "Chelsea", Lambda = 1.5 },
			new Team { Name = "Manchester United", Lambda = 1.6 },
			new Team { Name = "Arsenal", Lambda = 1.4 }
		};
    }
}
