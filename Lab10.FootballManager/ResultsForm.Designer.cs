namespace Lab10.FootballManager
{
	partial class ResultsForm
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
			this.listPanel = new System.Windows.Forms.Panel();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.resultLabel = new System.Windows.Forms.Label();
			this.resultList = new System.Windows.Forms.ListView();
			this.listPanel.SuspendLayout();
			this.headerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// listPanel
			// 
			this.listPanel.Controls.Add(this.resultList);
			this.listPanel.Location = new System.Drawing.Point(12, 83);
			this.listPanel.Name = "listPanel";
			this.listPanel.Size = new System.Drawing.Size(956, 528);
			this.listPanel.TabIndex = 0;
			// 
			// headerPanel
			// 
			this.headerPanel.Controls.Add(this.resultLabel);
			this.headerPanel.Location = new System.Drawing.Point(12, 12);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(956, 65);
			this.headerPanel.TabIndex = 1;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.resultLabel.Location = new System.Drawing.Point(371, 18);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(226, 33);
			this.resultLabel.TabIndex = 0;
			this.resultLabel.Text = "Результат тура";
			// 
			// resultList
			// 
			this.resultList.BackColor = System.Drawing.Color.SkyBlue;
			this.resultList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resultList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.resultList.HideSelection = false;
			this.resultList.Location = new System.Drawing.Point(0, 0);
			this.resultList.Name = "resultList";
			this.resultList.Size = new System.Drawing.Size(956, 528);
			this.resultList.TabIndex = 0;
			this.resultList.UseCompatibleStateImageBehavior = false;
			// 
			// ResultsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(980, 623);
			this.Controls.Add(this.headerPanel);
			this.Controls.Add(this.listPanel);
			this.Name = "ResultsForm";
			this.Text = "ResultsForm";
			this.listPanel.ResumeLayout(false);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel listPanel;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.ListView resultList;
	}
}