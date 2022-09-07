using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class Persona : Form
    {
        SqlConnection conn;
        public Persona(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    String sql = "select * from tbl_usuario";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dvgListado.DataSource = dt;
                    dvgListado.Refresh();   
                }
                else
                {
                    MessageBox.Show("La conexion esta cerrada");
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show("Error de conexion: " + ie.ToString());
                throw;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dvgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Persona_Load(object sender, EventArgs e)
        {

        }
    }
}
