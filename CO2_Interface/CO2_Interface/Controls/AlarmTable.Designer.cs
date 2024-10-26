
namespace CO2_Interface.Controls
{
    partial class AlarmTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AlarmGrid = new System.Windows.Forms.DataGridView();
            this.btApplyConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxCritic = new System.Windows.Forms.TextBox();
            this.tbMinCritic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idMenu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxWarning = new System.Windows.Forms.TextBox();
            this.tbMinWarning = new System.Windows.Forms.TextBox();
            this.updateIdMenu = new System.Windows.Forms.Timer(this.components);
            this.groupBoxAlarm = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGrid)).BeginInit();
            this.groupBoxAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlarmGrid
            // 
            this.AlarmGrid.AllowUserToAddRows = false;
            this.AlarmGrid.AllowUserToDeleteRows = false;
            this.AlarmGrid.AllowUserToResizeColumns = false;
            this.AlarmGrid.AllowUserToResizeRows = false;
            this.AlarmGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AlarmGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AlarmGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.AlarmGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlarmGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AlarmGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AlarmGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AlarmGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.AlarmGrid.Location = new System.Drawing.Point(5, 6);
            this.AlarmGrid.MultiSelect = false;
            this.AlarmGrid.Name = "AlarmGrid";
            this.AlarmGrid.ReadOnly = true;
            this.AlarmGrid.RowHeadersVisible = false;
            this.AlarmGrid.RowHeadersWidth = 62;
            this.AlarmGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AlarmGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AlarmGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.AlarmGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Navy;
            this.AlarmGrid.RowTemplate.ReadOnly = true;
            this.AlarmGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlarmGrid.Size = new System.Drawing.Size(712, 591);
            this.AlarmGrid.TabIndex = 2;
            // 
            // btApplyConfig
            // 
            this.btApplyConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btApplyConfig.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btApplyConfig.FlatAppearance.BorderSize = 0;
            this.btApplyConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btApplyConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApplyConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btApplyConfig.ForeColor = System.Drawing.Color.White;
            this.btApplyConfig.Location = new System.Drawing.Point(5, 456);
            this.btApplyConfig.Name = "btApplyConfig";
            this.btApplyConfig.Size = new System.Drawing.Size(347, 79);
            this.btApplyConfig.TabIndex = 15;
            this.btApplyConfig.Text = "Apply";
            this.btApplyConfig.UseVisualStyleBackColor = false;
            this.btApplyConfig.Click += new System.EventHandler(this.BtApplyConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Critical Max :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Critical Min :";
            // 
            // tbMaxCritic
            // 
            this.tbMaxCritic.Location = new System.Drawing.Point(204, 171);
            this.tbMaxCritic.Name = "tbMaxCritic";
            this.tbMaxCritic.Size = new System.Drawing.Size(91, 38);
            this.tbMaxCritic.TabIndex = 12;
            this.tbMaxCritic.Text = "0";
            // 
            // tbMinCritic
            // 
            this.tbMinCritic.Location = new System.Drawing.Point(204, 290);
            this.tbMinCritic.Name = "tbMinCritic";
            this.tbMinCritic.Size = new System.Drawing.Size(91, 38);
            this.tbMinCritic.TabIndex = 11;
            this.tbMinCritic.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID :";
            // 
            // idMenu
            // 
            this.idMenu.FormattingEnabled = true;
            this.idMenu.Location = new System.Drawing.Point(204, 121);
            this.idMenu.Name = "idMenu";
            this.idMenu.Size = new System.Drawing.Size(91, 39);
            this.idMenu.Sorted = true;
            this.idMenu.TabIndex = 9;
            this.idMenu.SelectedIndexChanged += new System.EventHandler(this.idMenu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Warning Max :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Warning Min :";
            // 
            // tbMaxWarning
            // 
            this.tbMaxWarning.Location = new System.Drawing.Point(204, 210);
            this.tbMaxWarning.Name = "tbMaxWarning";
            this.tbMaxWarning.Size = new System.Drawing.Size(91, 38);
            this.tbMaxWarning.TabIndex = 17;
            this.tbMaxWarning.Text = "0";
            // 
            // tbMinWarning
            // 
            this.tbMinWarning.Location = new System.Drawing.Point(204, 250);
            this.tbMinWarning.Name = "tbMinWarning";
            this.tbMinWarning.Size = new System.Drawing.Size(91, 38);
            this.tbMinWarning.TabIndex = 16;
            this.tbMinWarning.Text = "0";
            // 
            // updateIdMenu
            // 
            this.updateIdMenu.Enabled = true;
            this.updateIdMenu.Interval = 1000;
            this.updateIdMenu.Tick += new System.EventHandler(this.UpdateIdMenu_Tick);
            // 
            // groupBoxAlarm
            // 
            this.groupBoxAlarm.Controls.Add(this.label5);
            this.groupBoxAlarm.Controls.Add(this.label4);
            this.groupBoxAlarm.Controls.Add(this.tbMaxWarning);
            this.groupBoxAlarm.Controls.Add(this.tbMinWarning);
            this.groupBoxAlarm.Controls.Add(this.btApplyConfig);
            this.groupBoxAlarm.Controls.Add(this.label3);
            this.groupBoxAlarm.Controls.Add(this.label2);
            this.groupBoxAlarm.Controls.Add(this.tbMaxCritic);
            this.groupBoxAlarm.Controls.Add(this.tbMinCritic);
            this.groupBoxAlarm.Controls.Add(this.label1);
            this.groupBoxAlarm.Controls.Add(this.idMenu);
            this.groupBoxAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBoxAlarm.ForeColor = System.Drawing.Color.White;
            this.groupBoxAlarm.Location = new System.Drawing.Point(731, 57);
            this.groupBoxAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAlarm.Name = "groupBoxAlarm";
            this.groupBoxAlarm.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAlarm.Size = new System.Drawing.Size(357, 540);
            this.groupBoxAlarm.TabIndex = 20;
            this.groupBoxAlarm.TabStop = false;
            this.groupBoxAlarm.Text = "Configuration";
            // 
            // AlarmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxAlarm);
            this.Controls.Add(this.AlarmGrid);
            this.Name = "AlarmTable";
            this.Size = new System.Drawing.Size(1111, 600);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGrid)).EndInit();
            this.groupBoxAlarm.ResumeLayout(false);
            this.groupBoxAlarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView AlarmGrid;
        private System.Windows.Forms.Button btApplyConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox idMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer updateIdMenu;
        internal System.Windows.Forms.GroupBox groupBoxAlarm;
        internal System.Windows.Forms.TextBox tbMaxCritic;
        internal System.Windows.Forms.TextBox tbMinCritic;
        internal System.Windows.Forms.TextBox tbMaxWarning;
        internal System.Windows.Forms.TextBox tbMinWarning;
    }
}
