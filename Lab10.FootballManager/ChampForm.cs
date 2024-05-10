using Lab10.FootballManager.Data;
using Lab10.FootballManager.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab10.FootballManager
{
	public partial class ChampForm : Form
	{
		private Championship _championship;
		private BindingList<Team> _teams;
		private BindingSource _teamsBindingSource = new BindingSource();

		public ChampForm()
		{
			InitializeComponent();

			_championship = new Championship(GameData.Teams);

			// Настройки таблицы
			teamsGrid.AutoGenerateColumns = false;

			teamsGrid.DefaultCellStyle.Font = new Font(teamsGrid.Font.FontFamily, 
				teamsGrid.Font.Size + 2, FontStyle.Regular);
			teamsGrid.ColumnHeadersDefaultCellStyle.Font = new Font(teamsGrid.Font.FontFamily, 
				teamsGrid.Font.Size + 2, FontStyle.Bold);

			_teams = new BindingList<Team>(_championship.ChampTeams);
			_teamsBindingSource.DataSource = _teams;
			teamsGrid.DataSource = _teamsBindingSource;

			teamsGrid.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Name",
				HeaderText = "Команда",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
			});

			teamsGrid.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "MatchesPlayed",
				HeaderText = "Матчи",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});

			teamsGrid.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Wins",
				HeaderText = "Победы",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});

			teamsGrid.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Goals",
				HeaderText = "Голы",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});

			teamsGrid.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Points",
				HeaderText = "Очки",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});

			teamsGrid.CurrentCell = null;
			teamsGrid.DefaultCellStyle.SelectionBackColor = teamsGrid.DefaultCellStyle.BackColor;
			teamsGrid.DefaultCellStyle.SelectionForeColor = teamsGrid.DefaultCellStyle.ForeColor;
		}

		private void teamsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (teamsGrid.Rows[e.RowIndex].Selected)
			{
				e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
				e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
			}
		}

		private void tourButton_Click(object sender, EventArgs e)
		{
			if (_championship.CurrentTour < _championship.AllToursCount)
			{
				var tourResults = _championship.ConductTour();

				_teams = new BindingList<Team>(_championship.ChampTeams
					.OrderByDescending(team => team.Points)
					.ToList());

				_teamsBindingSource.DataSource = _teams;

				var resultsForm = new ResultsForm(tourResults);
				resultsForm.Show();
			}
			else
			{
				MessageBox.Show("Все туры сыграны.\nПоздравляем победителей!");
			}
		}
	}
}
