
namespace CO2_Interface.Controls
{
    partial class StatsTable
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timer_200ms = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.idMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rHours = new System.Windows.Forms.RadioButton();
            this.rMinutes = new System.Windows.Forms.RadioButton();
            this.rSeconds = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            this.Chart.BackSecondaryColor = System.Drawing.Color.MintCream;
            this.Chart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          //  this.Chart.ChartAreas[0].AxisX.LineColor = Color.White;
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Margin = new System.Windows.Forms.Padding(2);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(712, 591);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "MyChart";
            // 
            // Timer_200ms
            // 
            this.Timer_200ms.Enabled = true;
            this.Timer_200ms.Interval = 200;
            this.Timer_200ms.Tick += new System.EventHandler(this.Timer_200ms_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(775, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID :";
            // 
            // idMenu
            // 
            this.idMenu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.idMenu.FormattingEnabled = true;
            this.idMenu.Location = new System.Drawing.Point(826, 86);
            this.idMenu.Name = "idMenu";
            this.idMenu.Size = new System.Drawing.Size(84, 21);
            this.idMenu.Sorted = true;
            this.idMenu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(775, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time  :";
            // 
            // rHours
            // 
            this.rHours.AutoSize = true;
            this.rHours.ForeColor = System.Drawing.Color.White;
            this.rHours.Location = new System.Drawing.Point(835, 200);
            this.rHours.Name = "rHours";
            this.rHours.Size = new System.Drawing.Size(53, 17);
            this.rHours.TabIndex = 13;
            this.rHours.Text = "Hours";
            this.rHours.UseVisualStyleBackColor = true;
            // 
            // rMinutes
            // 
            this.rMinutes.AutoSize = true;
            this.rMinutes.ForeColor = System.Drawing.Color.White;
            this.rMinutes.Location = new System.Drawing.Point(835, 177);
            this.rMinutes.Name = "rMinutes";
            this.rMinutes.Size = new System.Drawing.Size(62, 17);
            this.rMinutes.TabIndex = 12;
            this.rMinutes.Text = "Minutes";
            this.rMinutes.UseVisualStyleBackColor = true;
            // 
            // rSeconds
            // 
            this.rSeconds.AutoSize = true;
            this.rSeconds.Checked = true;
            this.rSeconds.ForeColor = System.Drawing.Color.White;
            this.rSeconds.Location = new System.Drawing.Point(835, 154);
            this.rSeconds.Name = "rSeconds";
            this.rSeconds.Size = new System.Drawing.Size(67, 17);
            this.rSeconds.TabIndex = 11;
            this.rSeconds.TabStop = true;
            this.rSeconds.Text = "Seconds";
            this.rSeconds.UseVisualStyleBackColor = true;
            // 
            // StatsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rHours);
            this.Controls.Add(this.rMinutes);
            this.Controls.Add(this.rSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idMenu);
            this.Controls.Add(this.Chart);
            this.Name = "StatsTable";
            this.Size = new System.Drawing.Size(1111, 600);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Timer Timer_200ms;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox idMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rHours;
        private System.Windows.Forms.RadioButton rMinutes;
        private System.Windows.Forms.RadioButton rSeconds;
    }
}
