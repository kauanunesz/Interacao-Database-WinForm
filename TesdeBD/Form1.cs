namespace TesdeBD
{
    using MySql.Data.MySqlClient;
    using System.Data;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_list_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost; database=db_usuario;Uid=root; Pwd=root;";
            string query = "SELECT id, nome, email FROM tb_usuarios";

            using (MySqlConnection con = new MySqlConnection(conexao)) 
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataVG_tela.DataSource = dt;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}
