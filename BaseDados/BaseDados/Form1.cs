// Sql Server CE
using System.Data.SqlServerCe;

// SQLite
using System.Data.SQLite;

// MySQL
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        SqlCeConnection conexaoSSCE = new SqlCeConnection();
        SQLiteConnection conexaoSQLite = new SQLiteConnection();
        MySqlConnection conexaoMySql = new MySqlConnection();
        bool conectado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Conectar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            /*
            if (conectado)
            {
                DialogResult res = MessageBox.Show("Você deseja encerrar a conexão com o banco de dados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    try
                    {
                        conexaoSSCE.Close();

                        conectado = false;
                        AlterarConectar();

                        statusBancoResLabel.Text = "Desconectado";
                        statusNomeConexao.Text = "Sem conexão";

                        Utilitarios.Alertas.MensagemInformacao("Conexão encerrada.");

                    }
                    catch (Exception ex)
                    {
                        Utilitarios.Alertas.MensagemInformacao(ex.Message);
                    }
                }
            }
            else
            {
                string baseDados = Path.Combine(Application.StartupPath, @"db\DB_SQLServer.sdf");

                string strConexao = $@"DataSource = {baseDados}; Password = '05232004'";

                SqlCeEngine db = new SqlCeEngine(strConexao);

                try
                {
                    if (!(File.Exists(baseDados)))
                    {
                        db.CreateDatabase();
                    }
                }
                catch (Exception ex)
                {
                    Utilitarios.Alertas.MensagemInformacao(ex.Message);
                    return;
                }
                finally
                {
                    db.Dispose();
                }

                try
                {
                    conexaoSSCE.ConnectionString = strConexao;
                    conexaoSSCE.Open();
                    statusBancoResLabel.Text = "Conexão realizada com sucesso";
                    statusNomeConexao.Text = $"{conexaoSSCE.ServerVersion} (SQL Server CE)";

                    conectado = true;
                    AlterarConectar();

                    Utilitarios.Alertas.MensagemInformacao("Conectado com sucesso");
                }
                catch (Exception ex)
                {
                    Utilitarios.Alertas.MensagemInformacao(ex.Message);
                    return;
                }
            }
            */
            #endregion

            #region SQLite
            /*
            if (conectado)
            {
                DialogResult res = MessageBox.Show("Você deseja encerrar a conexão com o banco de dados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    try
                    {
                        conexaoSQLite.Close();

                        conectado = false;
                        AlterarConectar();

                        statusBancoResLabel.Text = "Desconectado";
                        statusNomeConexao.Text = "Sem conexão";

                        Utilitarios.Alertas.MensagemInformacao("Conexão encerrada.");

                    }
                    catch (Exception ex)
                    {
                        Utilitarios.Alertas.MensagemInformacao(ex.Message);
                    }
                }
            }
            else
            {
                string baseDados = Path.Combine(Application.StartupPath, @"db\DB_SQLite.db");
                string strConexao = $@"Data Source = {baseDados};  Version = 3";

                try
                {
                    if (!(File.Exists(baseDados)))
                    {
                        SQLiteConnection.CreateFile(baseDados);
                    }
                }
                catch (Exception ex)
                {
                    Utilitarios.Alertas.MensagemInformacao(ex.Message);
                    return;
                }

                try
                {
                    conexaoSQLite.ConnectionString = strConexao;
                    conexaoSQLite.Open();
                    statusBancoResLabel.Text = "Conexão realizada com sucesso";
                    statusNomeConexao.Text = $"{conexaoSQLite.ServerVersion} (SQLite)";

                    conectado = true;
                    AlterarConectar();

                    Utilitarios.Alertas.MensagemInformacao("Conectado com sucesso");
                }
                catch (Exception ex)
                {
                    Utilitarios.Alertas.MensagemInformacao(ex.Message);
                    return;
                }
            }
            */
            #endregion

            #region MySQL

            string strConexao1 = "server=127.0.0.1;User Id=juan;password=05232004";
            // string strConexao2 = "server=127.0.0.1;User Id=juan;database=teste_db;password=05232004";

            if (conectado)
            {
                DialogResult res = MessageBox.Show("Você deseja encerrar a conexão com o banco de dados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    try
                    {
                        conexaoMySql.Close();

                        conectado = false;
                        AlterarConectar();

                        statusBancoResLabel.Text = "Desconectado";
                        statusNomeConexao.Text = "Sem conexão";

                        Utilitarios.Alertas.MensagemInformacao("Conexão encerrada.");

                    }
                    catch (Exception ex)
                    {
                        Utilitarios.Alertas.MensagemInformacao(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    conexaoMySql.ConnectionString = strConexao1;
                    conexaoMySql.Open();
                    statusBancoResLabel.Text = "Conexão realizada com sucesso";
                    statusNomeConexao.Text = $"{conexaoMySql.ServerVersion} (MySql)";

                    conectado = true;
                    AlterarConectar();

                    Utilitarios.Alertas.MensagemInformacao("Conectado com sucesso");

                    MySqlCommand comando = new MySqlCommand();
                    try
                    {
                        comando.Connection = conexaoMySql;
                        comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db;";                       
                    }
                    catch (Exception ex)
                    {
                        Utilitarios.Alertas.MensagemInformacao(ex.Message);
                        return;
                    }
                    finally
                    {
                        comando.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Utilitarios.Alertas.MensagemInformacao(ex.Message);
                    return;
                }
            }

            #endregion
        }
        private void AlterarConectar()
        {
            if (conectado)
            {
                button_Conectar.Text = "Encerrar";
            }
            else
            {
                button_Conectar.Text = "Conectar";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexaoSSCE.Close();
            conexaoSQLite.Close();
            conexaoMySql.Close();
        }

        private void button_CriarTabela_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            /*
            string baseDados = Path.Combine(Application.StartupPath, @"db\DB_SQLServer.sdf");
            string strConexao = $@"DataSource = {baseDados}; Password = '05232004'";

            SqlCeConnection conexao = new SqlCeConnection();
            try
            {
                conexao.ConnectionString = strConexao;
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                try
                {
                    comando.Connection = conexao;
                    comando.CommandText = @"
                        CREATE TABLE pessoas (
                            id INT NOT NULL PRIMARY KEY,
                            nome NVARCHAR(50),
                            email NVARCHAR(50)
                        );
                    ";

                    comando.ExecuteNonQuery();

                    Utilitarios.Alertas.MensagemInformacao("Tabela criada com sucesso.");
                }
                catch (Exception ex)
                {
                    Utilitarios.Alertas.MensagemInformacao(ex.Message);
                }
                finally
                {
                    comando.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            */
            #endregion

            #region SQLite
            /*
            string baseDados = Path.Combine(Application.StartupPath, @"db\DB_SQLite.db");
            string strConexao = $@"Data Source = {baseDados};  Version = 3";

            SQLiteConnection conexao = new SQLiteConnection();
            try
            {
                conexao.ConnectionString = strConexao;
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                try
                {
                    comando.Connection = conexao;
                    comando.CommandText = @"
                        CREATE TABLE pessoas (
                            id INT NOT NULL PRIMARY KEY,
                            nome NVARCHAR(50),
                            email NVARCHAR(50)
                        );
                    ";

                    comando.ExecuteNonQuery();

                    Utilitarios.Alertas.MensagemInformacao("Tabela criada com sucesso.");
                }
                catch (Exception ex)
                {
                    Utilitarios.Alertas.MensagemInformacao(ex.Message);
                }
                finally
                {
                    comando.Dispose();
                }

            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            */
            #endregion

            #region MySql

            string strConexao2 = "server=127.0.0.1;User Id=juan;database=curso_db;password=05232004";

            MySqlConnection conexao = new MySqlConnection();
            try
            {
                conexao.ConnectionString = strConexao2;
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                try
                {
                    comando.Connection = conexao;
                    comando.CommandText = @"
                        CREATE TABLE pessoas (
                            id INT NOT NULL,
                            nome VARCHAR(50),
                            email VARCHAR(50),
                            PRIMARY KEY(id)
                        );
                    ";

                    comando.ExecuteNonQuery();

                    Utilitarios.Alertas.MensagemInformacao("Tabela criada com sucesso.");
                }
                catch (Exception ex)
                {
                    Utilitarios.Alertas.MensagemInformacao(ex.Message);
                }
                finally
                {
                    comando.Dispose();
                }

            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            #endregion
        }
    }
}
