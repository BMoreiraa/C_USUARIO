using System;

namespace MODEL
{
    public class Usuario
    {
        private String nomeUsuario;
        private int id;
        private string senha;
        private bool ativo;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set{nomeUsuario = value; }
            
        }//nome
        public int Id
        {
            get { return id; }
            set { id = value; }
        }//id
        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }//SENHA
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }//ativo

    }//USUARIO

}//MODEL