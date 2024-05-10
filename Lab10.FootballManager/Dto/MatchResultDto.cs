using Lab10.FootballManager.Enum;

namespace Lab10.FootballManager.Dto
{
	public class MatchResultDto
	{
        public TeamDto FirstTeam { get; set; }

        public TeamDto SecondTeam { get; set; }

        public MatchResult Result { get; set; }
    }
}
