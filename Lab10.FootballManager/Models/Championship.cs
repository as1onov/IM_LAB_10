using Lab10.FootballManager.Dto;
using Lab10.FootballManager.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Lab10.FootballManager.Models
{
	public class Championship
	{
        public BindingList<Team> ChampTeams { get; set; }

        public int AllToursCount { get; set; }

        public int CurrentTour { get; set; }

		private List<Team> _tempTeams;

		private Team _fixedTeam;

        public Championship(List<Team> teams)
        {
            AllToursCount = teams.Count - 1;
            CurrentTour = 0;
            ChampTeams = new BindingList<Team>(teams);
			_tempTeams = new List<Team>(teams.Skip(1));
			_fixedTeam = ChampTeams[0];
        }

		private MatchResultDto PlayMatch(Team team1, Team team2)
		{
			var goals1 = team1.ModelingGoals();
			var goals2 = team2.ModelingGoals();

			MatchResult result;

			if (goals1 > goals2)
			{
				result = MatchResult.FirstTeamWin;
				team1.CalculatePoints(isWin: true);
				team2.CalculatePoints();
			}
			else if (goals1 < goals2)
			{
				result = MatchResult.SecondTeamWin;
				team1.CalculatePoints();
				team2.CalculatePoints(isWin: true);
			}
			else
			{
				result = MatchResult.Draw;
				team1.CalculatePoints(isDraw: true);
				team2.CalculatePoints(isDraw: true);
			}

			return new MatchResultDto()
			{
				FirstTeam = new TeamDto(team1.Name, goals1),
				SecondTeam = new TeamDto(team2.Name, goals2),
				Result = result
			};
		}

		public List<MatchResultDto> ConductTour()
		{
			var results = new List<MatchResultDto>();

			var numberOfMatchesPerRound = ChampTeams.Count / 2;

			for (int match = 0; match < numberOfMatchesPerRound; match++)
			{
				var home = (match == 0) ? _fixedTeam : _tempTeams[match - 1];
				var away = _tempTeams[(_tempTeams.Count - match) % _tempTeams.Count];

				results.Add(PlayMatch(home, away));
			}

			_tempTeams.Insert(0, _tempTeams[_tempTeams.Count - 1]);
			_tempTeams.RemoveAt(_tempTeams.Count - 1);

			CurrentTour += 1;

			return results;
		}
	}
}
