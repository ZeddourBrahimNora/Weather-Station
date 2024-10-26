
namespace CO2_Interface.Controls
{
    partial class CreateUserTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.User_Grid = new System.Windows.Forms.DataGridView();
            this.Access_Grid = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbRights = new System.Windows.Forms.Label();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.boxRights = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.timer1sec = new System.Windows.Forms.Timer(this.components);
            this.boxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Access_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Grid
            // 
            this.User_Grid.AllowUserToAddRows = false;
            this.User_Grid.AllowUserToDeleteRows = false;
            this.User_Grid.AllowUserToResizeColumns = false;
            this.User_Grid.AllowUserToResizeRows = false;
            this.User_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.User_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.User_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.User_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.User_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.User_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.User_Grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.User_Grid.Location = new System.Drawing.Point(3, 3);
            this.User_Grid.MultiSelect = false;
            this.User_Grid.Name = "User_Grid";
            this.User_Grid.ReadOnly = true;
            this.User_Grid.RowHeadersVisible = false;
            this.User_Grid.RowHeadersWidth = 62;
            this.User_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.User_Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.User_Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.User_Grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Navy;
            this.User_Grid.RowTemplate.ReadOnly = true;
            this.User_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.User_Grid.Size = new System.Drawing.Size(1105, 354);
            this.User_Grid.TabIndex = 2;
            // 
            // Access_Grid
            // 
            this.Access_Grid.AllowUserToAddRows = false;
            this.Access_Grid.AllowUserToDeleteRows = false;
            this.Access_Grid.AllowUserToResizeColumns = false;
            this.Access_Grid.AllowUserToResizeRows = false;
            this.Access_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Access_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Access_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.Access_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Access_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Access_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Access_Grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.Access_Grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Access_Grid.Location = new System.Drawing.Point(3, 447);
            this.Access_Grid.MultiSelect = false;
            this.Access_Grid.Name = "Access_Grid";
            this.Access_Grid.ReadOnly = true;
            this.Access_Grid.RowHeadersVisible = false;
            this.Access_Grid.RowHeadersWidth = 62;
            this.Access_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Access_Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Access_Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.Access_Grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Navy;
            this.Access_Grid.RowTemplate.ReadOnly = true;
            this.Access_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Access_Grid.Size = new System.Drawing.Size(1105, 150);
            this.Access_Grid.TabIndex = 2;
            this.Access_Grid.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(170, 387);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(101, 31);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Name :";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(401, 387);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(90, 31);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "Pass :";
            // 
            // lbRights
            // 
            this.lbRights.AutoSize = true;
            this.lbRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbRights.ForeColor = System.Drawing.Color.White;
            this.lbRights.Location = new System.Drawing.Point(624, 387);
            this.lbRights.Name = "lbRights";
            this.lbRights.Size = new System.Drawing.Size(107, 31);
            this.lbRights.TabIndex = 4;
            this.lbRights.Text = "Rights :";
            // 
            // boxPass
            // 
            this.boxPass.Location = new System.Drawing.Point(497, 397);
            this.boxPass.Name = "boxPass";
            this.boxPass.Size = new System.Drawing.Size(121, 20);
            this.boxPass.TabIndex = 6;
            // 
            // boxRights
            // 
            this.boxRights.FormattingEnabled = true;
            this.boxRights.Items.AddRange(new object[] {
            "Admin",
            "Master",
            "User"});
            this.boxRights.Location = new System.Drawing.Point(757, 397);
            this.boxRights.Name = "boxRights";
            this.boxRights.Size = new System.Drawing.Size(151, 21);
            this.boxRights.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(947, 380);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 53);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // timer1sec
            // 
            this.timer1sec.Enabled = true;
            this.timer1sec.Interval = 1000;
            this.timer1sec.Tick += new System.EventHandler(this.Timer1sec_Tick);
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(277, 398);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(118, 20);
            this.boxID.TabIndex = 9;
            // 
            // CreateUserTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.boxRights);
            this.Controls.Add(this.boxPass);
            this.Controls.Add(this.lbRights);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.Access_Grid);
            this.Controls.Add(this.User_Grid);
            this.Name = "CreateUserTable";
            this.Size = new System.Drawing.Size(1111, 600);
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Access_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbRights;
        private System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.ComboBox boxRights;
        internal System.Windows.Forms.TextBox boxPass;
        internal System.Windows.Forms.TextBox boxID;
        internal System.Windows.Forms.DataGridView User_Grid;
        internal System.Windows.Forms.DataGridView Access_Grid;
        internal System.Windows.Forms.Timer timer1sec;
    }
}
