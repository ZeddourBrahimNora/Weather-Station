
namespace CO2_Interface.Controls
{
    partial class LoginUserTable
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.boxPassLogin = new System.Windows.Forms.TextBox();
            this.boxIDLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(247, 175);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(148, 46);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Name :";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(264, 275);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(131, 46);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Pass :";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(440, 375);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(229, 86);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // boxPassLogin
            // 
            this.boxPassLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.boxPassLogin.Location = new System.Drawing.Point(440, 272);
            this.boxPassLogin.Margin = new System.Windows.Forms.Padding(2);
            this.boxPassLogin.Name = "boxPassLogin";
            this.boxPassLogin.Size = new System.Drawing.Size(229, 53);
            this.boxPassLogin.TabIndex = 3;
            // 
            // boxIDLogin
            // 
            this.boxIDLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.boxIDLogin.Location = new System.Drawing.Point(440, 172);
            this.boxIDLogin.Margin = new System.Windows.Forms.Padding(2);
            this.boxIDLogin.Name = "boxIDLogin";
            this.boxIDLogin.Size = new System.Drawing.Size(229, 53);
            this.boxIDLogin.TabIndex = 4;
            // 
            // LoginUserTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.boxIDLogin);
            this.Controls.Add(this.boxPassLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginUserTable";
            this.Size = new System.Drawing.Size(1111, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button buttonLogin;
        internal System.Windows.Forms.TextBox boxPassLogin;
        internal System.Windows.Forms.TextBox boxIDLogin;
    }
}
