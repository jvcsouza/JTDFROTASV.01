﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JTDFROTAS.Classes
{
    public class Marca : ICRUD
    {
        private int id;
        private String nome;
        private bool ativo;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        public Marca(String nome)
        {

        }
        public Marca(int id, String nome, bool ativo)
        {
            Nome = nome;
            Id = id;
            Ativo = ativo;
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

        public static DataTable Listar(bool ativo)
        {
            Conexao.Query = "SELECT * FROM MARCAVEICULO WHERE ATIVO = " + (ativo ? '1' : '0');
            return Conexao.ExecAdapter();
        }
        public static DataTable Listar()
        {
            Conexao.Query = "SELECT * FROM MARCAVEICULO";
            return Conexao.ExecAdapter();
        }

        public static Marca Buscar(int id)
        {
            Marca m;
            Conexao.Query = $"SELECT * FROM MARCAVEICULO"
                            + " WHERE ID = " + id
                            + " AND ATIVO = 1";
            SqlDataReader dr = Conexao.ExecReader();
            if (dr.Read())
                m = new Marca((int) dr["id"], dr["nome"].ToString(), (bool) dr["ativo"]);
            else
                m = new Marca(0, null, false);
            dr.Close();
            return m;
        }

        bool ICRUD.Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
