using System;
using System.Data.SqlClient;
using System.Data;

namespace JTDFROTAS.Classes
{
    class Conexao
    {
        private static SqlConnection _conn;
        private static SqlCommand com;

        public static SqlConnection Conn
        {
            get => _conn != null && _conn.State == ConnectionState.Open 
                    ? _conn 
                    : _conn = new SqlConnection(_url);
            private set => _conn = value; 
        }

        private static String _url = "Data Source=netcodes.ddns.net;Initial Catalog=JTDFROTAS;User ID=JTDFROTAS;password=340$Uuxwp7Mcxo7Khy";
        private static String _query = "";

        public Conexao()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    return;
                _conn.Open();
                Console.WriteLine(Conn.State);
            }
            catch(SqlException sqlError)
            {
                Console.WriteLine(sqlError.ErrorCode);
                Console.WriteLine(sqlError.Message);
            }
            catch (NullReferenceException Error)
            {
                Console.WriteLine(Error.Message);
            }
        }

        public static String Query
        {
            private get => _query;
            set => _query = value;
        }

        public static SqlDataReader ExecReader()
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = Query;
                comando.Connection = Conn;

                reader = comando.ExecuteReader();
               
            }catch(Exception err)
            {
                System.Windows.Forms.MessageBox.Show(Form1.container, err.Message, $"ERROR {err.HResult}", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            return reader;
        }

        public static DataTable ExecAdapter()
        {
            DataTable dtb = new DataTable();
            try
            {
                //Conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, Conn);

                adapter.Fill(dtb);

                //Conn.Dispose();
                //adapter.Dispose();
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return dtb;
        }

        public static int ExecQuery()
        {
            try
            {
                com = new SqlCommand();
                if (String.IsNullOrWhiteSpace(Query))
                    throw new ArgumentException("Query sql invalída!");
                com.CommandText = Query;
                com.Connection = Conn;
                object lines = com.ExecuteScalar();

                //Conn.Dispose();
                com.Dispose();
                return Convert.ToInt32(lines.ToString());
            }
            catch (SqlException sqlError)
            {
                Console.WriteLine(sqlError.Message);
                return 0;
            }
        }

        public int ExecQuery(String sql)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                if (String.IsNullOrWhiteSpace(sql))
                    throw new ArgumentException("Query sql invalída!");
                comando.CommandText = sql;
                comando.Connection = Conn;
                int lines = comando.ExecuteNonQuery();
                Console.WriteLine(lines);
                Console.WriteLine(sql);
                //Conn.Dispose();
                comando.Dispose();
                return lines;
            }
            catch(SqlException sqlError)
            {
                Console.WriteLine(sqlError.Message);
                return 0;
            }
        }

    }
}