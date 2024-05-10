using System;

namespace Lab10.FootballManager.Models
{
	public class Team
	{
        public string Name { get; set; }

        public int Points { get; set; }

        public int Goals { get; set; }

		public int MatchesPlayed { get; set; }

		public int Wins { get; set; }

        public double Lambda { get; set; }

        public void Reset()
        {
			Points = 0;
			Goals = 0;
			MatchesPlayed = 0;
			Wins = 0;
        }

		public void CalculatePoints(bool isWin=false, bool isDraw=false)
		{
			MatchesPlayed += 1;
			
			if (isWin)
			{
				Wins += 1;
				Points += 3;
			}
			else if (isDraw)
			{
				Points += 1;
			}
		}

		public int ModelingGoals()
		{
			var m = -1;
			var S = 0d;

			var rnd = new Random();
			do
			{
				m += 1;
				var num = rnd.NextDouble();
				S = S + Math.Log(num);
			}
			while (S > -Lambda);

			Goals += m;

			return m;
		}
    }
}
