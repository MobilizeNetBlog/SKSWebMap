using System;
using System.Data.Common;
using UpgradeHelpers.DB.ADO;

namespace SKS
{
	internal static class modConnection
	{


		private static DbConnection _CurrentConnection = null;
		internal static DbConnection CurrentConnection
		{
			get
			{
				if (_CurrentConnection is null)
				{
					_CurrentConnection = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
				}
				return _CurrentConnection;
			}
			set
			{
				_CurrentConnection = value;
			}
		}

		private static ADORecordSetHelper _rs = null;
		internal static ADORecordSetHelper rs
		{
			get
			{
				if (_rs is null)
				{
					_rs = new ADORecordSetHelper("");
				}
				return _rs;
			}
			set
			{
				_rs = value;
			}
		}

		private static ADORecordSetHelper _rs2 = null;
		internal static ADORecordSetHelper rs2
		{
			get
			{
				if (_rs2 is null)
				{
					_rs2 = new ADORecordSetHelper("");
				}
				return _rs2;
			}
			set
			{
				_rs2 = value;
			}
		}


		internal static void OpenConnection()
		{
			CurrentConnection = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
			//UPGRADE_TODO: (7010) The connection string must be verified to fullfill the .NET data provider connection string requirements. More Information: https://www.mobilize.net/vbtonet/ewis/ewi7010
			CurrentConnection.ConnectionString = modMain.ConnectionString;
			CurrentConnection.Open();
		}

		internal static void ExecuteSql(string Statement)
		{
			rs = new ADORecordSetHelper("");
			rs.Open(Statement, CurrentConnection, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
		}

		internal static void ExecuteSql2(string Statement)
		{
			rs2 = new ADORecordSetHelper("");
			rs2.Open(Statement, CurrentConnection, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
		}
	}
}