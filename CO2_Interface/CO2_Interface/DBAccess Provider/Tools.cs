using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // fournisseur de la bdd access

namespace CO2_Interface.DBAccess_Provider
{
	class Tools
	{
		internal static OleDbDataAdapter Adapter = new OleDbDataAdapter();

		internal static OleDbConnection connexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
																			+
																		@"Data Source=..\..\..\DB_UserAccess.accdb;Cache Authentication=True"); // connexion a la bdd

		internal static void Config()
		{
			string Insert_CommandText = "INSERT into UserTable(UserName,UserPassword,Access_Id) values(@UserName,@UserPassword,@Access_Id);";
			string Delete_CommandText = "DELETE FROM UserTable WHERE UserName = @UserName;";
			string Select_CommandText = "SELECT * from UserTable ORDER BY UserKey_Id;";
			string Update_CommandText = "UPDATE UserTable SET UserPassword = @UserPassword, Access_Id = @Access_Id WHERE UserName = @UserName;";

			OleDbCommand Insert_Command = new OleDbCommand(Insert_CommandText, connexion);
			OleDbCommand Delete_Command = new OleDbCommand(Delete_CommandText, connexion);
			OleDbCommand Select_Command = new OleDbCommand(Select_CommandText, connexion);
			OleDbCommand Update_Command = new OleDbCommand(Update_CommandText, connexion);
			// associer les commandes aux adapteurs correspondants
			Adapter.SelectCommand = Select_Command;
			Adapter.InsertCommand = Insert_Command;
			Adapter.DeleteCommand = Delete_Command;
			Adapter.UpdateCommand = Update_Command;
			//  mapping -> la table de bdd usertable est lié a la table local usertable
			Adapter.TableMappings.Add("UserTable", "Users");
			Adapter.TableMappings.Add("AccessTable", "Access");
			// définition des types dans la bdd 
			Adapter.InsertCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
			Adapter.InsertCommand.Parameters.Add("@UserPassword", OleDbType.VarChar, 40, "UserPassword");
			Adapter.InsertCommand.Parameters.Add("@Access_Id", OleDbType.Numeric, 100, "Access_Id");
			Adapter.DeleteCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
		}
	}
}
