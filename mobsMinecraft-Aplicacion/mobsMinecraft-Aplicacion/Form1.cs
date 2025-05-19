using Microsoft.Data.Sqlite;

namespace mobsMinecraft_Aplicacion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strDeConexion = "Data Source = Minecraft.sqlite";
        SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

        conexion.Open();

        SqliteCommand comando = new SqliteCommand($"INSERT INTO Mobs (Nombre) VALUES ('{textBox1.Text}')", conexion); //consulta


        comando.ExecuteNonQuery();

            conexion.Close();
        }
}
}
