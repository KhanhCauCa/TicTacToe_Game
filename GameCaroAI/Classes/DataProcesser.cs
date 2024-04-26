using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaroAI.Classes
{
    internal class DataProcesser
    {
        string connectStr = "Data Source=DESKTOP-SVVHT2F\\SQLEXPRESS;Initial Catalog=GameCaroAI;Integrated Security=True";
        SqlConnection sqlConn = null;

        public void OpenConnect()
        {
            sqlConn = new SqlConnection(connectStr);
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }
        }
        public void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)
                sqlConn.Close();
            sqlConn.Dispose();
        }
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlSelect, sqlConn);
            dtAdapter.Fill(dt);
            CloseConnect();
            dtAdapter.Dispose();
            return dt;
        }
        public DataTable SearchData(string sqlSelect, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlSelect, sqlConn);

            foreach (var parameter in parameters)
            {
                dtAdapter.SelectCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            dtAdapter.Fill(dt);
            CloseConnect();
            dtAdapter.Dispose();
            return dt;
        }
        public bool ChangeData(string sql, Dictionary<string, object> parameters)
        {
            int k = 0;
            OpenConnect();
            using (SqlCommand cmd = new SqlCommand(sql, sqlConn))
            {
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
                k++;
                cmd.ExecuteNonQuery();

            }
            CloseConnect();
            return k > 0;
        }
        public string GeneratePlayerID()
        {
            string newPlayerID = "";
            OpenConnect();
            using (SqlCommand cmd = new SqlCommand("SELECT 'TK' + RIGHT('000' + CAST(ISNULL(MAX(SUBSTRING(PlayerID, 3, 3)), 0) + 1 AS NVARCHAR(3)), 3) FROM Player", sqlConn))
            {
                newPlayerID = (string)cmd.ExecuteScalar();
            }
            CloseConnect();
            return newPlayerID;
        }
        public T GetScalarValue<T>(string sql)
        {
            OpenConnect();
            using (SqlCommand cmd = new SqlCommand(sql, sqlConn))
            {
                object result = cmd.ExecuteScalar();
                CloseConnect();
                return (T)Convert.ChangeType(result, typeof(T));
            }
        }
        public string GenerateGameID()
        {
            string newGameID = "";
            OpenConnect();
            using (SqlCommand cmd = new SqlCommand("SELECT 'G' + RIGHT('000' + CAST(ISNULL(MAX(SUBSTRING(GameID, 3, 3)), 0) + 1 AS NVARCHAR(3)), 3) FROM Game", sqlConn))
            {
                newGameID = (string)cmd.ExecuteScalar();
            }
            CloseConnect();
            return newGameID;
        }
    }
}
