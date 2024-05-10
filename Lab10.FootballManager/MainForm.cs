using Lab10.FootballManager.Data;
using System;
using System.Windows.Forms;

namespace Lab10.FootballManager
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			GameData.Teams.ForEach(x => x.Reset());
			
			var champForm = new ChampForm();
			champForm.Show();
		}
	}
}
