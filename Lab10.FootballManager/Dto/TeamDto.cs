namespace Lab10.FootballManager.Dto
{
	public class TeamDto
	{
        public string Name { get; set; }

        public int Goals { get; set; }

        public TeamDto(string name, int goals)
        {
            Name = name;
			Goals = goals;
        }
    }
}
