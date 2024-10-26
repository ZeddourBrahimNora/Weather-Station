using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace CO2_Interface.DBAccess_Provider
{
	class DataReader
	{

		internal static void Read(DataGridView Grid, DataTable dt, string DB_Table)
		{
			DataTable Table = new DataTable();

			DataColumn ID = new DataColumn("ID");
			DataColumn Name = new DataColumn("Name");
			DataColumn Password = new DataColumn("Password");
			DataColumn Access = new DataColumn("Access Type");

			Table.Columns.Add(ID);
			Table.Columns.Add(Name);
			Table.Columns.Add(Password);
			Table.Columns.Add(Access);

			OleDbCommand SelectCommand = new OleDbCommand("SELECT * from " + DB_Table + ";", Tools.connexion);

			try
			 {
				dt.Rows.Clear();
				Tools.connexion.Open(); // on se connecte a la DB

				OleDbDataReader DBReader = SelectCommand.ExecuteReader();

				if (DBReader.HasRows)
				{
					while (DBReader.Read())
					{
						//MessageBox.Show("Row : " + DBReader[0] + " " + DBReader[1] + " " + DBReader[2] + " " + DBReader[3]);
						Table.Rows.Add(new object[] { DBReader[0], DBReader[1], DBReader[2], DBReader[3] }); // ça correspond aux colonnes de la table UserTable dans acces
						//CO2_Interface.MainForm.LocalUserTable.Rows.Add(new object[] { DBReader[0], DBReader[1], DBReader[2], DBReader[3] });
						dt.Rows.Add(new object[] { DBReader[0], DBReader[1], DBReader[2], DBReader[3] });
					}
				}

				DBReader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " file:DataReader");
			}
			finally
			{
				Tools.connexion.Close();
			}
			
				Grid.DataSource = Table;
		}
	}
}


