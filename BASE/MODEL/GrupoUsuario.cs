using System;
using System.Collections.Generic;

namespace MODEL
{
    class GrupoUsuario
    {
        private String descrição;
        private List<Usuario> usuarios;
        private List<Permissão> permissões;

        public String Descrição
        {
            get { return descrição; }
            set { descrição = value; }
        }

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        public List<Permissão> Permissões
        {
            get { return permissões; }
            set { permissões = value; }
        }

    }//GRUPO USUARIO

}//MODEL