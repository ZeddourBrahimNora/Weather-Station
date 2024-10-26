using System;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Data.OleDb;

namespace CO2_Interface
{
    public partial class MainForm : Form
    {
        int timeCount;

        internal Controls.MeasureTable MeasureTablePage;

        internal Controls.AlarmTable AlarmTablePage;

        internal Controls.StatsTable StatsTablePage;

        internal Controls.CreateUserTable CreateUserTablePage;

        internal Controls.LoginUserTable LoginUserTablePage;

        internal Controls.ErrorUserTable ErrorUserTablePage;
        // création du dataSet qui va contenir les 2 tables User + Access
        internal DataSet UserAccess;
        // création de la table User

        static internal DataTable LocalUserTable;

        internal DataColumn UserKey_ID;
        internal DataColumn UserName;
        internal DataColumn UserPassword;
        internal DataColumn Access_Id; // clé étrangère vers AccessTable
                                       // création de la table Access
        internal DataTable LocalAccessTable;

        internal DataColumn AccessKey_Id;
        internal DataColumn AccessName;
        internal DataColumn AllowCreateID;
        internal DataColumn AllowDestroyID;
        internal DataColumn AllowConfigAlarm;
        internal DataColumn UserCreation;

        public MainForm()
        {
            InitializeComponent();

            DBAccess_Provider.Tools.Config(); // permettre la synchronisation entre la bdd locale et la bdd access

            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            //Creation des pages
            this.MeasureTablePage = new Controls.MeasureTable();
            this.AlarmTablePage = new Controls.AlarmTable();
            this.StatsTablePage = new Controls.StatsTable();
            this.CreateUserTablePage = new Controls.CreateUserTable();
            this.LoginUserTablePage = new Controls.LoginUserTable();
            this.ErrorUserTablePage = new Controls.ErrorUserTable();

            //Les events Handler
            this.CreateUserTablePage.AddUser += new EventHandler(CreateUserTableInsideButton);
            this.CreateUserTablePage.TimerTick += new EventHandler(Timer1secInsideButton);
            this.LoginUserTablePage.LoginClick += new EventHandler(LoginUserTableInsideButton);
            this.MeasureTablePage.ApplyMeasureClick += new EventHandler(ApplyMeasureConfig);
            this.MeasureTablePage.DeleteMeasureClick += new EventHandler(DeleteMeasure);
            this.AlarmTablePage.ApplyAlarmClick += new EventHandler(ApplyAlarmConfig);


            //Ouverture du port
            OpenPort();

            initPortMenu();

            //Permet d'ouvrir la page de connexion dès l'ouverture de l'app
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(CreateUserTablePage);

            TableCreation();

            InitDataSet();

            DBAccess_Provider.DataReader.Read(CreateUserTablePage.User_Grid, LocalUserTable, "UserTable");

        }



        //Creation des table de données
        private static void TableCreation()
        {
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ConfigStatus);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Type);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Data);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.LastUpdate);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Alarm);
            ////////////////////////////
            Data.Tables.DataFromSensorAlarm.Columns.Add(Data.Tables.Columns2.ID);
            Data.Tables.DataFromSensorAlarm.Columns.Add(Data.Tables.Columns2.Type);
            Data.Tables.DataFromSensorAlarm.Columns.Add(Data.Tables.Columns2.WarningMin);
            Data.Tables.DataFromSensorAlarm.Columns.Add(Data.Tables.Columns2.CriticalMin);
            Data.Tables.DataFromSensorAlarm.Columns.Add(Data.Tables.Columns2.WarningMax);
            Data.Tables.DataFromSensorAlarm.Columns.Add(Data.Tables.Columns2.CriticalMax);
            Data.Tables.DataFromSensorAlarm.Columns.Add(Data.Tables.Columns2.Status);
            ////////////////////////////
            Data.Tables.DataTableAccess.Columns.Add(Data.Tables.Columns3.ID);
            Data.Tables.DataTableAccess.Columns.Add(Data.Tables.Columns3.AccessIDPK);
            Data.Tables.DataTableAccess.Columns.Add(Data.Tables.Columns3.AllowCreateID);
            Data.Tables.DataTableAccess.Columns.Add(Data.Tables.Columns3.AllowDestroyID);
            Data.Tables.DataTableAccess.Columns.Add(Data.Tables.Columns3.AllowConfigAlarm);
            Data.Tables.DataTableAccess.Columns.Add(Data.Tables.Columns3.UserCreation);
            //////////////
            Data.Tables.DataTableError.Columns.Add(Data.Tables.Columns4.Ref);
            Data.Tables.DataTableError.Columns.Add(Data.Tables.Columns4.Type);
            Data.Tables.DataTableError.Columns.Add(Data.Tables.Columns4.Date);
            Data.Tables.DataTableError.Columns.Add(Data.Tables.Columns4.Description);


            //Tri par ID
            DataView dv = Data.Tables.DataFromSensorAlarm.DefaultView;
            DataView dv2 = Data.Tables.DataFromSensor.DefaultView;
            DataView dv3 = Data.Tables.DataTableError.DefaultView;
            dv.Sort = "ID";
            dv2.Sort = "ID";
        }
        //Creation du dataset
        private void InitDataSet()
        {
            UserAccess = new DataSet();

            // déterminer les types + les propriétés pour la table User
            LocalUserTable = new DataTable();

            UserKey_ID = new DataColumn("ID", System.Type.GetType("System.Int32"));
            UserName = new DataColumn("Name", System.Type.GetType("System.String"));
            UserPassword = new DataColumn("Password", System.Type.GetType("System.String"));
            Access_Id = new DataColumn("Access Type", System.Type.GetType("System.Int32"));
            // déterminer les types + les propriétés pour la table User
            LocalAccessTable = new DataTable();

            AccessKey_Id = new DataColumn("ID", System.Type.GetType("System.Int32"));
            AccessName = new DataColumn("Name", System.Type.GetType("System.String"));
            AllowCreateID = new DataColumn("Create ID", System.Type.GetType("System.Boolean"));
            AllowDestroyID = new DataColumn("Destroy ID", System.Type.GetType("System.Boolean"));
            AllowConfigAlarm = new DataColumn("Config Alarm", System.Type.GetType("System.Boolean"));
            UserCreation = new DataColumn("User Creation", System.Type.GetType("System.Boolean"));


            // Data relation (contraintes etc)
            // User table
            // clé primaire non nulle
            LocalUserTable.TableName = "Users";

            UserKey_ID.Unique = true;
            UserKey_ID.AutoIncrement = true;
            LocalUserTable.Columns.Add(UserKey_ID);
            // index unique non nulle
            UserName.Unique = true;
            LocalUserTable.Columns.Add(UserName);

            UserPassword.Unique = false;
            LocalUserTable.Columns.Add(UserPassword);

            Access_Id.Unique = false;
            LocalUserTable.Columns.Add(Access_Id);

            // Data relation (contraintes etc)
            // Access table
            // clé primaire non nulle
            LocalAccessTable.TableName = "Access";
            AccessKey_Id.Unique = true;
            LocalAccessTable.Columns.Add(AccessKey_Id);

            AccessName.Unique = true;
            LocalAccessTable.Columns.Add(AccessName);

            AllowCreateID.Unique = false;
            LocalAccessTable.Columns.Add(AllowCreateID);

            AllowDestroyID.Unique = false;
            LocalAccessTable.Columns.Add(AllowDestroyID);

            AllowConfigAlarm.Unique = false;
            LocalAccessTable.Columns.Add(AllowConfigAlarm);

            UserCreation.Unique = false;
            LocalAccessTable.Columns.Add(UserCreation);

            // DataRelation -> déterminer les clés primaires/étrangères
            UserAccess.Tables.Add(LocalUserTable);
            UserAccess.Tables.Add(LocalAccessTable);
            // indiquer que l'id pointe dans la table access et que l'access type pointe dans la table users
            DataColumn parentColumn = UserAccess.Tables["Access"].Columns["ID"];
            DataColumn childColumn = UserAccess.Tables["Users"].Columns["Access type"];
            // création de la clé étrangère 
            DataRelation relation = new DataRelation("Access2User", parentColumn, childColumn);
            // ajout de la relation dans la table Users
            UserAccess.Tables["Users"].ParentRelations.Add(relation);

            // déterminer les droit pour chaque type d'user
            UserAccess.Tables[1].Rows.Add(new object[] { 0, "AdminRights", true, true, true, true });
            UserAccess.Tables[1].Rows.Add(new object[] { 1, "MasterRights", true, true, true, false });
            UserAccess.Tables[1].Rows.Add(new object[] { 2, "UserRights", false, false, false, false });
            // ajouter un utilisateur admin + user normal
           // LocalUserTable.Rows.Add(999, "", "", 0);
        }

        //Code relatif au Serial Port
        private void initPortMenu()
        {

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                portCOM_Menu.Items.Add(port);
            }


        }
        private void OpenPort()
        {
            //Permet l'ouverture du port
            try
            {
                SerialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                /****** CODE EXAMEN : DEBUT ******/
                MessageBox.Show(DateTime.Now + " - " + " Erreur de type : 1 ");
                /******CODE EXAMEN: FIN * *****/
            }
            //On commence le traitement dès l'ouverture du port

            timerTreatement.Enabled = true;
        }
        private void portCOM_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort.Close();

            SerialPort.PortName =
            portCOM_Menu.Items[portCOM_Menu.SelectedIndex].ToString();

            OpenPort();

            MessageBox.Show("" + SerialPort.PortName.ToString());
        }
        // Signin
        private void CreateUserTableInsideButton(object sender, EventArgs e)
        {
            // inserer dans la db ce que l'user met dans les diff champs
            DBAccess_Provider.Adapter.Insert(CreateUserTablePage.boxID.Text, CreateUserTablePage.boxPass.Text, CreateUserTablePage.boxRights.SelectedIndex);
            DBAccess_Provider.DataReader.Read(CreateUserTablePage.User_Grid, LocalUserTable, "UserTable");
        }

        // Login 
        private void LoginUserTableInsideButton(object sender, EventArgs e)
        {

            // parcourir chaque ligne et chercher si boxIDLogin existe dans la dt -> envoyé le resultat sous forme de booléen
             DataColumn[] columns = LocalUserTable.Columns.Cast<DataColumn>().ToArray();
             bool userExists = LocalUserTable.AsEnumerable().Any(row => columns.Any(col => row[col].ToString() == LoginUserTablePage.boxIDLogin.Text ));


             DataColumn[] columns2 = LocalUserTable.Columns.Cast<DataColumn>().ToArray();
             bool correctPass = LocalUserTable.AsEnumerable().Any(row => columns.Any(col => row[col].ToString() == LoginUserTablePage.boxPassLogin.Text));



            // l'user existe bien
            if (userExists == true && correctPass == true) // si l'user existe et si le mdp est correcte
            {

                ResetPermissions();

                //lbLoggedUser.Text = "Bienvenue "+ LoginUserTablePage.boxPassLogin.Text;


                foreach (DataRow row in LocalUserTable.Rows)
                {
                    if (row["Name"].ToString() == LoginUserTablePage.boxIDLogin.Text)
                    {
                        foreach (DataRow line in LocalAccessTable.Rows)
                        {
                            if (row["Access Type"].ToString() == line["ID"].ToString())
                            {
                                if (line["Create ID"].Equals(true))
                                {
                                    MeasureTablePage.groupBoxMeasure.Enabled = true;
                                }

                                if (line["Destroy ID"].Equals(true))
                                {
                                    MeasureTablePage.btDelete.Enabled = true;
                                }

                                if (line["Config Alarm"].Equals(true))
                                {
                                    AlarmTablePage.groupBoxAlarm.Enabled = true;
                                }

                                if (line["User Creation"].Equals(true))
                                {
                                    createUserButton.Enabled = true;
                                    CreateUserButton_Click(sender, e);
                                }
                               
                            }

                        }


                    }
                }


                //On est connecté, on active les bouttons
                measureButton.Enabled = true;
                alarmButton.Enabled = true;
                statsButton.Enabled = true;
                settingsButton.Enabled = true;
                ErrorUserTablePage.Enabled = true;

            }
            else
            {
                MessageBox.Show("Le compte n'existe pas ou les informations introduites sont erronées");
                /****** CODE EXAMEN : DEBUT ******/
                MessageBox.Show(DateTime.Now + " - " + " Erreur de type : 4 ");
                /******CODE EXAMEN: FIN * *****/
            }
        }
        private void ResetPermissions()
        {
            createUserButton.Enabled = false;
            AlarmTablePage.groupBoxAlarm.Enabled = false;
            AlarmTablePage.groupBoxAlarm.Enabled = false;
            MeasureTablePage.groupBoxMeasure.Enabled = false;
            MeasureTablePage.btDelete.Enabled = false;
           // ErrorUserTablePage.Enabled = false;
        }

        //Configuration/Supression des mesures
        private void ApplyMeasureConfig(object sender, EventArgs e)
        {
            int highLimit = Int32.Parse(MeasureTablePage.tbMaxValue.Text);
            int lowLimit = Int32.Parse(MeasureTablePage.tbMinValue.Text);
            bool correctInput = true;

            if (MeasureTablePage.idMenu.SelectedIndex != -1)
            {
                foreach (Data.FromSensor.Measure item in Data.Collections.ObjectList)
                {
                    if (item.ID == (byte)MeasureTablePage.idMenu.SelectedItem)
                    {

                        if (item.ID != 0)
                        {

                            if (highLimit < lowLimit)
                            {
                                correctInput = false;
                                MessageBox.Show("Erreur ! Veuillez insérer vos valeurs du plus grand au plus petit");
                            }

                            if (correctInput)
                            {

                                item.HighLimit = highLimit;
                                item.LowLimit = lowLimit;
                                item.ConfigStatus = true;

                                if (item.CriticalMax == 0)
                                {
                                    item.CriticalMax = Int32.Parse(MeasureTablePage.tbMaxValue.Text);
                                    item.WarningMax = Int32.Parse(MeasureTablePage.tbMaxValue.Text);
                                    item.WarningMin = Int32.Parse(MeasureTablePage.tbMinValue.Text);
                                    item.CriticalMin = Int32.Parse(MeasureTablePage.tbMinValue.Text);
                                }
                            }
                        }
                    }
                }
            }
            else MessageBox.Show("Please select ID");

        }

        private void DeleteMeasure(object sender, EventArgs e)
        {
            if (MeasureTablePage.idMenu.SelectedIndex != -1)
            {
                foreach (Data.FromSensor.Measure item in Data.Collections.ObjectList)
                {
                    if (item.ID == (byte)MeasureTablePage.idMenu.SelectedItem)
                    {
                        Data.Collections.ObjectList.Remove(item);
                        break;
                    }
                }
            }
            else MessageBox.Show("Please select ID");
        }

        //Configuration des alarmes
        private void ApplyAlarmConfig(object sender, EventArgs e)
        {
            int Cmax = Int32.Parse(AlarmTablePage.tbMaxCritic.Text);
            int Wmax = Int32.Parse(AlarmTablePage.tbMaxWarning.Text);
            int Wmin = Int32.Parse(AlarmTablePage.tbMinWarning.Text);
            int Cmin = Int32.Parse(AlarmTablePage.tbMinCritic.Text);
            bool correctInput = true;

            if (AlarmTablePage.idMenu.SelectedIndex != -1)
            {
                foreach (Data.FromSensor.Base measureObj in Data.Collections.ObjectList)
                {
                    if (measureObj.ID == (byte)AlarmTablePage.idMenu.SelectedItem)
                    {
                        if (measureObj.ID != 0)
                        {

                            //Si une valeur min est plus grande qu'une valeur max et vice-versa = Erreur
                            if ((Cmax < Cmin || Cmax < Wmax || Cmax < Wmin) || (Cmin > Cmax || Cmin > Wmax || Cmin > Wmin) || (Wmax > Cmax || Wmax < Cmin || Wmax < Wmin) || (Wmin > Cmax || Wmin < Cmin || Wmin > Wmax))
                            {
                                correctInput = false;
                                MessageBox.Show("Erreur ! Veuillez insérer vos valeurs du plus grand au plus petit");
                            }


                            if (correctInput)
                            {
                                Data.FromSensor.Measure item = (Data.FromSensor.Measure)measureObj;
                                item.CriticalMax = Cmax;
                                item.WarningMax = Wmax;
                                item.WarningMin = Wmax;
                                item.CriticalMin = Cmin;
                            }

                        }
                    }
                }
            }
            else MessageBox.Show("Please select ID");

        }

        // Les Timers
        private void Timer1secInsideButton(object sender, EventArgs e)
        {
           // CreateUserTablePage.Access_Grid.DataSource = UserAccess.Tables[1];
            //DBAccess_Provider.DataReader.Read(CreateUserTablePage.User_Grid, LocalUserTable, "UserTable");
        }
        private void TimerTreatement_Tick(object sender, EventArgs e)
        {

            //Permet la visualisation de la derniere màj
            SerialDataHandler.Reception.UpdateTreatment();
            //SAuvegarde les données pour le graph
            timeCount++;

            SerialDataHandler.Reception.SaveForGraphSeconds();

            if (timeCount % 60 == 0)
            {
                SerialDataHandler.Reception.SaveForGraphMinutes();
            }

            if (timeCount % 3600 == 0)
            {
                SerialDataHandler.Reception.SaveForGraphHours();
            }

            //Permet le traitement des données 
            SerialDataHandler.Reception.DataTreatment(Data.Tables.DataFromSensor, MeasureTablePage.MeasureGrid);
            ///Permet l'affichage des parametres sauvegardé
            SerialDataHandler.Reception.DataInsertion(Data.Tables.DataFromSensor, MeasureTablePage.MeasureGrid);
            //Permet le traitement des Alarmes
            SerialDataHandler.Reception.DataAlarmTreatment(Data.Tables.DataFromSensorAlarm, AlarmTablePage.AlarmGrid);
            //  for each object d'arraylist transfer => datagrid
            lbTime.Text = DateTime.Now.ToString();

        }

        //Bouton de sauvegarde et chargement
        private void BtLoadConfig_Click(object sender, EventArgs e)
        {
            SerialDataHandler.Reception.LoadConfig();
        }

        private void btSaveConfig_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;

            fileContent += "MeteoStation_Configuration_file\r\n";

            fileContent += "ID;";
            fileContent += "Type;";
            fileContent += "LowLimit;";
            fileContent += "HighLimit;";
            fileContent += "CriticMin;";
            fileContent += "WarningMin;";
            fileContent += "WarningMax;";
            fileContent += "CriticMax;";


            fileContent += "\r\n";

            fileContent += "Start";
            fileContent += "\r\n";

            foreach (Data.FromSensor.Measure item in Data.Collections.ObjectList)
            {
                if (item.ConfigStatus == true)
                {
                    fileContent += item.ID + ";";
                    fileContent += item.Type + ";";
                    fileContent += item.LowLimit + ";";
                    fileContent += item.HighLimit + ";";
                    fileContent += item.CriticalMin + ";";
                    fileContent += item.WarningMin + ";";
                    fileContent += item.WarningMax + ";";
                    fileContent += item.CriticalMax + ";";

                    fileContent += "\r\n";

                }


            }


            fileContent += "End";
            MessageBox.Show(fileContent);
            string filePath = Directory.GetCurrentDirectory();
            filePath += "\\Config.csv";

            StreamWriter Writer = new StreamWriter(filePath, false);
            Writer.Write(fileContent);
            Writer.Close();
        }


        //Boutton ToolStrip / Changement de page
        private void MeasureButton_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();//Permet d'ouvrir la page des mesures
            MyContainer.Controls.Add(MeasureTablePage);
        }

        private void AlarmButton_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();//Permet d'ouvrir la page des alarmes
            MyContainer.Controls.Add(AlarmTablePage);
            AlarmTablePage.AlarmGrid.DataSource = Data.Tables.DataFromSensorAlarm;
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();//Permet d'ouvrir la page des graphique
            MyContainer.Controls.Add(StatsTablePage);
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();//Permet d'ouvrir la page de création d'utilisateurs
            MyContainer.Controls.Add(CreateUserTablePage);
            CreateUserTablePage.Access_Grid.DataSource = Data.Tables.DataTableAccess;
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();//Permet d'ouvrir la page de connexion
            MyContainer.Controls.Add(LoginUserTablePage);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();//Permet d'ouvrir la page de connexion
            MyContainer.Controls.Add(ErrorUserTablePage);
            ErrorUserTablePage.dataGridViewError.DataSource = Data.Tables.DataTableError;
        }

      
    }
}
