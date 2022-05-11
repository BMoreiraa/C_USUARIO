using System;

namespace MODEL
{
    public class Usuario
    {
        private String nome;
        private int id;
        private int senha;
        private int ativo;

        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
        }//nome
        public int Id
        {
            get { return id; }
            set { id = value; }
        }//id
        public int Senha
        {
            get { return senha; }
            set { senha = value; }
        }//SENHA
        public int Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }//ativo

    }//USUARIO

}//MODEL