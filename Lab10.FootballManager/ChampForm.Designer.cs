namespace Lab10.FootballManager
{
	partial class ChampForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.headerPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.toursLabel = new System.Windows.Forms.Label();
			this.teamsPanel = new System.Windows.Forms.Panel();
			this.teamsGrid = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tourButton = new System.Windows.Forms.Button();
			this.headerPanel.SuspendLayout();
			this.teamsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.teamsGrid)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// headerPanel
			// 
			this.headerPanel.Controls.Add(this.label1);
			this.headerPanel.Controls.Add(this.toursLabel);
			this.headerPanel.Location = new System.Drawing.Point(12, 12);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(918, 78);
			this.headerPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(456, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Всего туров в чемпионате: 0";
			// 
			// toursLabel
			// 
			this.toursLabel.AutoSize = true;
			this.toursLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toursLabel.Location = new System.Drawing.Point(143, 27);
			this.toursLabel.Name = "toursLabel";
			this.toursLabel.Size = new System.Drawing.Size(231, 27);
			this.toursLabel.TabIndex = 0;
			this.toursLabel.Text = "Проведено туров: 0";
			// 
			// teamsPanel
			// 
			this.teamsPanel.Controls.Add(this.teamsGrid);
			this.teamsPanel.Location = new System.Drawing.Point(12, 96);
			this.teamsPanel.Name = "teamsPanel";
			this.teamsPanel.Size = new System.Drawing.Size(918, 476);
			this.teamsPanel.TabIndex = 1;
			// 
			// teamsGrid
			// 
			this.teamsGrid.AllowUserToAddRows = false;
			this.teamsGrid.AllowUserToDeleteRows = false;
			this.teamsGrid.AllowUserToResizeColumns = false;
			this.teamsGrid.AllowUserToResizeRows = false;
			this.teamsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.teamsGrid.BackgroundColor = System.Drawing.Color.SkyBlue;
			this.teamsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.teamsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.teamsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.teamsGrid.Location = new System.Drawing.Point(0, 0);
			this.teamsGrid.MultiSelect = false;
			this.teamsGrid.Name = "teamsGrid";
			this.teamsGrid.ReadOnly = true;
			this.teamsGrid.RowHeadersWidth = 62;
			this.teamsGrid.RowTemplate.Height = 28;
			this.teamsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.teamsGrid.Size = new System.Drawing.Size(918, 476);
			this.teamsGrid.TabIndex = 0;
			this.teamsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.teamsGrid_CellFormatting);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tourButton);
			this.panel1.Location = new System.Drawing.Point(12, 578);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(918, 79);
			this.panel1.TabIndex = 2;
			// 
			// tourButton
			// 
			this.tourButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.tourButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tourButton.ForeColor = System.Drawing.Color.Black;
			this.tourButton.Location = new System.Drawing.Point(634, 3);
			this.tourButton.Name = "tourButton";
			this.tourButton.Size = new System.Drawing.Size(222, 73);
			this.tourButton.TabIndex = 0;
			this.tourButton.Text = "Следующий тур";
			this.tourButton.UseVisualStyleBackColor = false;
			this.tourButton.Click += new System.EventHandler(this.tourButton_Click);
			// 
			// ChampForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(942, 669);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.teamsPanel);
			this.Controls.Add(this.headerPanel);
			this.Name = "ChampForm";
			this.Text = "ChampForm";
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.teamsPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.teamsGrid)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Panel teamsPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label toursLabel;
		private System.Windows.Forms.Button tourButton;
		private System.Windows.Forms.DataGridView teamsGrid;
	}
}