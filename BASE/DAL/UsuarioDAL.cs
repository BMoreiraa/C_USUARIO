using MODEL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_IserirUsuario";

                //-------------------------------------
                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit)
                {
                    Value = _usuario.Ativo
                };
                cmd.Parameters.Add(pativo);
                //modo alternativo-----------------------

                SqlParameter pNome = new SqlParameter("@Nome", SqlDbType.VarChar);
                pNome.Value = _usuario.Senha;
                cmd.Parameters.Add(pNome);

                SqlParameter psenha = new SqlParameter("@senha", SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);

                SqlParameter pId = new SqlParameter("@id", SqlDbType.Int);
                pId.Value = _usuario.Id;
                cmd.Parameters.Add(pId);

                cn.Open();
                _usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _usuario;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

    }//Usuario_DAL

}//DAL