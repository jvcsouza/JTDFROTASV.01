using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JTDFROTAS.Classes
{
    public class Cidade : ICRUD
    {
        private String _nome;
        private int _codUf, _id;
        private bool _ativo;
        private String _uf;

        public Cidade(int id, String nome, int codUf, bool ativo)
        {
            Id = id;
            Nome = nome;
            CodUf = codUf;
            Ativo = ativo;
        }
        public Cidade(String nome, String uf)
        {
            Nome = nome;
            Uf = uf;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int CodUf { get => _codUf; set => _codUf = value; }
        public int Id { get => _id; set => _id = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
        public string Uf { get => _uf; set => _uf = value; }

        public bool Atualizar()
        {
            throw new NotImplementedException();
        }

        bool ICRUD.Buscar(int id)
        {
            throw new NotImplementedException();
        }
        public static String Buscar(int idCidade)
        {
            Conexao.Query = $"SELECT NOME FROM CIDADE WHERE ID = {idCidade} AND ATIVO = 1";
            SqlDataReader dr = Conexao.ExecReader();
            String nome;
            if (!dr.Read())
                nome = "";
            else nome = dr[0].ToString();
            dr.Close();
            return nome;
        }
        public static int Buscar(String nome)
        {
            Conexao.Query = $"SELECT ID FROM CIDADE WHERE NOME LIKE '{nome}'";
            SqlDataReader dr = Conexao.ExecReader();
            int id;
            if (!dr.Read())
                id = 0;
            else id = Int32.Parse(dr[0].ToString());
            dr.Close();
            return id;
        }

        public static int BuscarRegistrar(String nome, String uf)
        {
            Conexao.Query = $"SELECT ID FROM CIDADE WHERE NOME LIKE '{nome}'";
            SqlDataReader dr = Conexao.ExecReader();
            int id;
            if (!dr.Read()) {
                dr.Close();
                id = new Cidade(nome, uf).RegistrarComUf();
            }
            else id = Int32.Parse(dr[0].ToString());
            dr.Close();
            return id;
        }

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = @"SELECT c.ID, u.ID as CODESTADO, c.NOME, u.NOME AS ESTADO, u.UF, c.ATIVO
                            FROM UF u
                            INNER JOIN CIDADE c
                            ON u.ID = c.CODUF
                            WHERE c.ATIVO = " + (ativo ? 1 : 0);
            return Conexao.ExecAdapter();
        }
        public static DataTable Listar()
        {
            Conexao.Query = @"SELECT c.ID, u.ID as CODESTADO, c.NOME, u.NOME AS ESTADO, u.UF, c.ATIVO
                            FROM UF u
                            INNER JOIN CIDADE c
                            ON u.ID = c.CODUF";
            return Conexao.ExecAdapter();
        }
        public bool Registrar()
        {
            return true;
        }
        public int RegistrarComUf()
        {
            Conexao.Query = $@"INSERT INTO CIDADE(NOME, CODUF)
                            VALUES ('{_nome}', (SELECT ID FROM UF WHERE UF LIKE '{_uf}'));
                             SELECT SCOPE_IDENTITY() AS ID";
            SqlDataReader dr = Conexao.ExecReader();
            int id;
            if (!dr.Read())
                return id = 0;
            id = Convert.ToInt32(dr[0].ToString());
            dr.Close();
            System.Windows.Forms.MessageBox.Show(Form1.container, $"Registro cidade {_nome.ToUpper()} Inserido automaticamente, talvez sejá necessario alteração manual do cadastro!", $"AVISO - Cadastro Automatico!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            return id;
        }
    }
}
