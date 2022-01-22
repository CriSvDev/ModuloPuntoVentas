using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloPuntoVentas
{
    public partial class frmLogeo : Form
    {
        public frmLogeo()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("server='servidor'; database= 'database' ;INTEGRATED SECURITY = true");
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASENA FROM PERSONA WHERE USUARIO = @vusuario AND CONTRASENA = @vcontrasena", conn);
            comando.Parameters.AddWithValue("@vusuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@vcontrasena", txtContrasena.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                conn.Close();
                frmPricipal pantalla = new frmPricipal();
                pantalla.Show();

            }

        }
    }
}
