using System;
using System.Data.SqlClient;

namespace JTDFROTAS.Classes
{
    public class Usuario : ICRUD
    {
        private static int id;
        private static String _nome;
        private static String _senha;

        public static String Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    return;
                _nome = value;
            }
        }
        private static String Senha
        {
            get
            {
                return _senha.ToUpper();
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    return;
                _senha = value;
            }
        }

        public static int Id { get => id; set => id = value; }

        public Usuario(String usuario, String senha)
        {
            Nome = usuario;
            Senha = senha;
        }
        public Usuario(String usuario, params String[] permissoes)
        {
            //this
        }

        public bool Logar()
        {
            Conexao.Query = $"EXECUTE LOGAR '{Nome}', '{Senha}'";
            SqlDataReader dr = Conexao.ExecReader();
            if (dr != null)
                if (dr.Read())
                    Id = Int32.Parse(dr[0].ToString());
                else Id = 0;
            if (!dr.IsClosed) dr.Close();
            return Id != 0 ? true : false;
        }

        public bool Registrar()
        {
            throw new NotImplementedException();
        }

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public bool Atualizar()
        {
            throw new NotImplementedException();
        }

        public bool Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
