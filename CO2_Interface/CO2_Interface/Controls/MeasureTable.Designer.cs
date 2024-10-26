
namespace CO2_Interface.Controls
{
    partial class MeasureTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MeasureGrid = new System.Windows.Forms.DataGridView();
            this.updateIdMenu = new System.Windows.Forms.Timer(this.components);
            this.groupBoxMeasure = new System.Windows.Forms.GroupBox();
            this.lbType = new System.Windows.Forms.Label();
            this.btApplyConfig = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.tbMinValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idMenu = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MeasureGrid)).BeginInit();
            this.groupBoxMeasure.SuspendLayout();
            this.SuspendLayout();
            // 
            // MeasureGrid
            // 
            this.MeasureGrid.AllowUserToAddRows = false;
            this.MeasureGrid.AllowUserToDeleteRows = false;
            this.MeasureGrid.AllowUserToResizeColumns = false;
            this.MeasureGrid.AllowUserToResizeRows = false;
            this.MeasureGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MeasureGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MeasureGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.MeasureGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MeasureGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MeasureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MeasureGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MeasureGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.MeasureGrid.Location = new System.Drawing.Point(5, 6);
            this.MeasureGrid.MultiSelect = false;
            this.MeasureGrid.Name = "MeasureGrid";
            this.MeasureGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MeasureGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MeasureGrid.RowHeadersVisible = false;
            this.MeasureGrid.RowHeadersWidth = 62;
            this.MeasureGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MeasureGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MeasureGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.MeasureGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Navy;
            this.MeasureGrid.RowTemplate.ReadOnly = true;
            this.MeasureGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MeasureGrid.Size = new System.Drawing.Size(712, 591);
            this.MeasureGrid.TabIndex = 2;
            // 
            // updateIdMenu
            // 
            this.updateIdMenu.Enabled = true;
            this.updateIdMenu.Interval = 1000;
            this.updateIdMenu.Tick += new System.EventHandler(this.UpdateIdMenu_Tick);
            // 
            // groupBoxMeasure
            // 
            this.groupBoxMeasure.Controls.Add(this.btDelete);
            this.groupBoxMeasure.Controls.Add(this.lbType);
            this.groupBoxMeasure.Controls.Add(this.btApplyConfig);
            this.groupBoxMeasure.Controls.Add(this.label7);
            this.groupBoxMeasure.Controls.Add(this.label8);
            this.groupBoxMeasure.Controls.Add(this.tbMaxValue);
            this.groupBoxMeasure.Controls.Add(this.tbMinValue);
            this.groupBoxMeasure.Controls.Add(this.label9);
            this.groupBoxMeasure.Controls.Add(this.idMenu);
            this.groupBoxMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBoxMeasure.ForeColor = System.Drawing.Color.White;
            this.groupBoxMeasure.Location = new System.Drawing.Point(731, 57);
            this.groupBoxMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMeasure.Name = "groupBoxMeasure";
            this.groupBoxMeasure.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMeasure.Size = new System.Drawing.Size(357, 540);
            this.groupBoxMeasure.TabIndex = 21;
            this.groupBoxMeasure.TabStop = false;
            this.groupBoxMeasure.Text = "Configuration";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(39, 190);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(0, 31);
            this.lbType.TabIndex = 17;
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btApplyConfig.Click += new System.EventHandler(this.btApplyConfig_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max Value :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Min Value :";
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Location = new System.Drawing.Point(204, 236);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(91, 38);
            this.tbMaxValue.TabIndex = 12;
            this.tbMaxValue.Text = "0";
            // 
            // tbMinValue
            // 
            this.tbMinValue.Location = new System.Drawing.Point(204, 290);
            this.tbMinValue.Name = "tbMinValue";
            this.tbMinValue.Size = new System.Drawing.Size(91, 38);
            this.tbMinValue.TabIndex = 11;
            this.tbMinValue.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(126, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID :";
            // 
            // idMenu
            // 
            this.idMenu.FormattingEnabled = true;
            this.idMenu.Location = new System.Drawing.Point(204, 134);
            this.idMenu.Name = "idMenu";
            this.idMenu.Size = new System.Drawing.Size(91, 39);
            this.idMenu.Sorted = true;
            this.idMenu.TabIndex = 9;
            this.idMenu.SelectedIndexChanged += new System.EventHandler(this.idMenu_SelectedIndexChanged);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(5, 374);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(347, 79);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // MeasureTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxMeasure);
            this.Controls.Add(this.MeasureGrid);
            this.Name = "MeasureTable";
            this.Size = new System.Drawing.Size(1111, 600);
            ((System.ComponentModel.ISupportInitialize)(this.MeasureGrid)).EndInit();
            this.groupBoxMeasure.ResumeLayout(false);
            this.groupBoxMeasure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView MeasureGrid;
        private System.Windows.Forms.Timer updateIdMenu;
        internal System.Windows.Forms.GroupBox groupBoxMeasure;
        private System.Windows.Forms.Button btApplyConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbType;
        internal System.Windows.Forms.ComboBox idMenu;
        internal System.Windows.Forms.TextBox tbMaxValue;
        internal System.Windows.Forms.TextBox tbMinValue;
        internal System.Windows.Forms.Button btDelete;
    }
}
