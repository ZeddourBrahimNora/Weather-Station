
namespace CO2_Interface.Controls
{
    partial class ErrorUserTable
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
            this.cBoxErrorType = new System.Windows.Forms.ComboBox();
            this.lbErrorType = new System.Windows.Forms.Label();
            this.dataGridViewError = new System.Windows.Forms.DataGridView();
            this.timerError = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewError)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxErrorType
            // 
            this.cBoxErrorType.FormattingEnabled = true;
            this.cBoxErrorType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBoxErrorType.Location = new System.Drawing.Point(693, 84);
            this.cBoxErrorType.Name = "cBoxErrorType";
            this.cBoxErrorType.Size = new System.Drawing.Size(113, 28);
            this.cBoxErrorType.TabIndex = 0;
            this.cBoxErrorType.SelectedIndexChanged += new System.EventHandler(this.cBoxErrorType_SelectedIndexChanged);
            // 
            // lbErrorType
            // 
            this.lbErrorType.AutoSize = true;
            this.lbErrorType.Location = new System.Drawing.Point(577, 92);
            this.lbErrorType.Name = "lbErrorType";
            this.lbErrorType.Size = new System.Drawing.Size(86, 20);
            this.lbErrorType.TabIndex = 1;
            this.lbErrorType.Text = "Error type :";
            // 
            // dataGridViewError
            // 
            this.dataGridViewError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewError.Location = new System.Drawing.Point(32, 61);
            this.dataGridViewError.Name = "dataGridViewError";
            this.dataGridViewError.RowHeadersWidth = 62;
            this.dataGridViewError.RowTemplate.Height = 28;
            this.dataGridViewError.Size = new System.Drawing.Size(539, 429);
            this.dataGridViewError.TabIndex = 2;
            // 
            // timerError
            // 
            this.timerError.Tick += new System.EventHandler(this.timerError_Tick);
            // 
            // ErrorUserTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewError);
            this.Controls.Add(this.lbErrorType);
            this.Controls.Add(this.cBoxErrorType);
            this.Name = "ErrorUserTable";
            this.Size = new System.Drawing.Size(851, 513);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbErrorType;
        internal System.Windows.Forms.ComboBox cBoxErrorType;
        private System.Windows.Forms.Timer timerError;
        internal System.Windows.Forms.DataGridView dataGridViewError;
    }
}
