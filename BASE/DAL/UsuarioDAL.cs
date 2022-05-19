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
                cn.ConnectionString = @"User ID=SA;Initial Catalog=LOJA;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirUsuario";

                //-------------------------------------
                SqlParameter pativo = new SqlParameter("@Ativo", SqlDbType.Bit)
                {
                    Value = _usuario.Ativo
                };
                cmd.Parameters.Add(pativo);
                //modo alternativo-----------------------

                SqlParameter pNome = new SqlParameter("@NomeUsuario", SqlDbType.VarChar);
                pNome.Value = _usuario.Nome;
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

        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection ();

            try
            {
                cn.ConnectionString = @"User ID=SA;Initial Catalog=LOJA;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarUsuario";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@filtro",SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            } 

        }//USUÁRIO

        public void Excluir(int _ID)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = @"User ID=SA;Initial Catalog=LOJA;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirUsuario";
                SqlParameter pid = new SqlParameter();
                pid.Value = _ID;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não foi posivel excluir o usuario: " + _ID.ToString());
                
            }
            catch (SqlException ex )
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch(Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }// EXCLUIR

        public Usuario Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            
            try
            {
                cn.ConnectionString = @"User ID=SA;Initial Catalog=LOJA;Data Source=.\SQLEXPRESS2019;Password=Senailab05";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarUsuario";
                //SqlParameter pUs = new SqlParameter();

                return _usuario;

            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex )
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