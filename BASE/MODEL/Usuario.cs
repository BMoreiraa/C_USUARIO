using System;

namespace MODEL
{
    public class Usuario
    {
        private String nome;
        private int id;
        private string senha;
        private bool ativo;

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