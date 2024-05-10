namespace Lab10.FootballManager
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainPanel = new System.Windows.Forms.Panel();
			this.nameLabel = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.SkyBlue;
			this.mainPanel.Controls.Add(this.startButton);
			this.mainPanel.Controls.Add(this.nameLabel);
			this.mainPanel.Location = new System.Drawing.Point(12, 12);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(448, 446);
			this.mainPanel.TabIndex = 0;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.BackColor = System.Drawing.Color.Transparent;
			this.nameLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameLabel.Location = new System.Drawing.Point(94, 35);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(250, 33);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Football Manager";
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.startButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startButton.ForeColor = System.Drawing.Color.Black;
			this.startButton.Location = new System.Drawing.Point(110, 120);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(219, 60);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Чемпионат";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 470);
			this.Controls.Add(this.mainPanel);
			this.Name = "MainForm";
			this.Text = "FootballManager";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label nameLabel;
	}
}

