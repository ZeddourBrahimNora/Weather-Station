namespace CO2_Interface
{
    partial class MainForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.timerTreatement = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.measureButton = new System.Windows.Forms.ToolStripButton();
            this.alarmButton = new System.Windows.Forms.ToolStripButton();
            this.statsButton = new System.Windows.Forms.ToolStripButton();
            this.createUserButton = new System.Windows.Forms.ToolStripButton();
            this.loginButton = new System.Windows.Forms.ToolStripButton();
            this.settingsButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.btLoadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.btSaveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.btDeleteConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.MyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.portCOM_Menu = new System.Windows.Forms.ComboBox();
            this.lbLoggedUser = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM2";
            // 
            // timerTreatement
            // 
            this.timerTreatement.Interval = 1000;
            this.timerTreatement.Tick += new System.EventHandler(this.TimerTreatement_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.measureButton,
            this.alarmButton,
            this.statsButton,
            this.createUserButton,
            this.loginButton,
            this.settingsButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(150, 1046);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "Menu";
            // 
            // measureButton
            // 
            this.measureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.measureButton.Enabled = false;
            this.measureButton.Image = ((System.Drawing.Image)(resources.GetObject("measureButton.Image")));
            this.measureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.measureButton.Name = "measureButton";
            this.measureButton.Size = new System.Drawing.Size(146, 68);
            this.measureButton.Text = "Measure";
            this.measureButton.Click += new System.EventHandler(this.MeasureButton_Click);
            // 
            // alarmButton
            // 
            this.alarmButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alarmButton.Enabled = false;
            this.alarmButton.Image = ((System.Drawing.Image)(resources.GetObject("alarmButton.Image")));
            this.alarmButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(146, 68);
            this.alarmButton.Text = "alarmButton";
            this.alarmButton.ToolTipText = "Alarm";
            this.alarmButton.Click += new System.EventHandler(this.AlarmButton_Click);
            // 
            // statsButton
            // 
            this.statsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statsButton.Enabled = false;
            this.statsButton.Image = ((System.Drawing.Image)(resources.GetObject("statsButton.Image")));
            this.statsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(146, 68);
            this.statsButton.Text = "statsButton";
            this.statsButton.ToolTipText = "Statistics";
            this.statsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // createUserButton
            // 
            this.createUserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createUserButton.Enabled = false;
            this.createUserButton.Image = ((System.Drawing.Image)(resources.GetObject("createUserButton.Image")));
            this.createUserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(146, 68);
            this.createUserButton.Text = "createUserButton";
            this.createUserButton.ToolTipText = "Manage User";
            this.createUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
            this.loginButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(146, 68);
            this.loginButton.Text = "loginButton";
            this.loginButton.ToolTipText = "Login";
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btLoadConfig,
            this.btSaveConfig,
            this.btDeleteConfig});
            this.settingsButton.Enabled = false;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(146, 68);
            this.settingsButton.Text = "Settings";
            // 
            // btLoadConfig
            // 
            this.btLoadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btLoadConfig.Name = "btLoadConfig";
            this.btLoadConfig.Size = new System.Drawing.Size(164, 34);
            this.btLoadConfig.Text = "Load";
            this.btLoadConfig.Click += new System.EventHandler(this.BtLoadConfig_Click);
            // 
            // btSaveConfig
            // 
            this.btSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btSaveConfig.Name = "btSaveConfig";
            this.btSaveConfig.Size = new System.Drawing.Size(164, 34);
            this.btSaveConfig.Text = "Save";
            this.btSaveConfig.Click += new System.EventHandler(this.btSaveConfig_Click);
            // 
            // btDeleteConfig
            // 
            this.btDeleteConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btDeleteConfig.Name = "btDeleteConfig";
            this.btDeleteConfig.Size = new System.Drawing.Size(164, 34);
            this.btDeleteConfig.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(146, 68);
            this.toolStripButton1.Text = "errorButton";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MyContainer
            // 
            this.MyContainer.Location = new System.Drawing.Point(166, 69);
            this.MyContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MyContainer.Name = "MyContainer";
            this.MyContainer.Size = new System.Drawing.Size(1666, 923);
            this.MyContainer.TabIndex = 6;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(159, 1046);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 46);
            this.lbTime.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 949);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 145);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // portCOM_Menu
            // 
            this.portCOM_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.portCOM_Menu.FormattingEnabled = true;
            this.portCOM_Menu.Location = new System.Drawing.Point(1652, 1006);
            this.portCOM_Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portCOM_Menu.Name = "portCOM_Menu";
            this.portCOM_Menu.Size = new System.Drawing.Size(180, 44);
            this.portCOM_Menu.TabIndex = 9;
            this.portCOM_Menu.Text = "COM2";
            this.portCOM_Menu.SelectedIndexChanged += new System.EventHandler(this.portCOM_Menu_SelectedIndexChanged);
            // 
            // lbLoggedUser
            // 
            this.lbLoggedUser.AutoSize = true;
            this.lbLoggedUser.BackColor = System.Drawing.Color.Transparent;
            this.lbLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbLoggedUser.ForeColor = System.Drawing.Color.White;
            this.lbLoggedUser.Location = new System.Drawing.Point(182, 14);
            this.lbLoggedUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoggedUser.Name = "lbLoggedUser";
            this.lbLoggedUser.Size = new System.Drawing.Size(0, 46);
            this.lbLoggedUser.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1851, 1046);
            this.Controls.Add(this.lbLoggedUser);
            this.Controls.Add(this.portCOM_Menu);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.MyContainer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Timer timerTreatement;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton measureButton;
        private System.Windows.Forms.ToolStripButton alarmButton;
        private System.Windows.Forms.FlowLayoutPanel MyContainer;
        private System.Windows.Forms.ToolStripButton statsButton;
        private System.Windows.Forms.ToolStripButton createUserButton;
        private System.Windows.Forms.ToolStripButton loginButton;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripDropDownButton settingsButton;
        private System.Windows.Forms.ToolStripMenuItem btLoadConfig;
        private System.Windows.Forms.ToolStripMenuItem btSaveConfig;
        private System.Windows.Forms.ToolStripMenuItem btDeleteConfig;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ComboBox portCOM_Menu;
        private System.Windows.Forms.Label lbLoggedUser;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

