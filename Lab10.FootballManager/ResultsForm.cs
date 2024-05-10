using Lab10.FootballManager.Dto;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab10.FootballManager
{
	public partial class ResultsForm : Form
	{
		public ResultsForm(List<MatchResultDto> results)
		{
			InitializeComponent();
			ShowMatchResults(results);
		}

		private void ShowMatchResults(IEnumerable<MatchResultDto> matchResults)
		{
			resultList.View = View.Details;
			resultList.Columns.Add("Первая команда", 150);
			resultList.Columns.Add("Голы", 50, HorizontalAlignment.Center);
			resultList.Columns.Add("Вторая команда", 150);
			resultList.Columns.Add("Голы", 50, HorizontalAlignment.Center);
			resultList.Columns.Add("Результат матча", 100, HorizontalAlignment.Center);

			foreach (var match in matchResults)
			{
				var row = new ListViewItem(match.FirstTeam.Name);
				row.SubItems.Add(match.FirstTeam.Goals.ToString());
				row.SubItems.Add(match.SecondTeam.Name);
				row.SubItems.Add(match.SecondTeam.Goals.ToString());
				row.SubItems.Add(match.Result.ToString());
				resultList.Items.Add(row);
			}

			resultList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			resultList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
	}
}
