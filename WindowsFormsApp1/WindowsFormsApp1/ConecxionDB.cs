using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace WindowsFormsApp1
{
    class ConecxionDB
    {
        String cadena = "Data Source=DESKTOP-F2CCQD0\\SQLEXPRESS; initial Catalog=NominaFUSADI; Integrated Security=True";
        public SqlConnection conectar = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;
        public ConecxionDB()
        {
            conectar.ConnectionString=cadena;
        }
      
        public void Abrir()
        {//Realiza conexion a la base de datos
            try
            {
                conectar.Open();
                Console.WriteLine("Exito");
            }
            catch(Exception ex)
            { Console.WriteLine("Error" + ex.Message); }
        }
        public void MostrarEmpleado(DataGridView dgv, int codigo)
        {//Selecciona de la base de datos La informacion de la vista de empleados
            try
            {
                
 
                da = new SqlDataAdapter("Select * from EmpleadosInfo Where Codigo="+codigo, conectar);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }

        public void MostrarDepartamento (DataGridView dgv, int codigo)
        {//Selecciona de la base de datos La informacion de la vista de empleados
            try
            {


                da = new SqlDataAdapter("Select * from Cargo Where DepartamentoCodigo=" + codigo, conectar);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }

        public void MostrarCargo(DataGridView dgv, int codigo)
        {//Selecciona de la base de datos La informacion de la vista de empleados
            try
            {


                da = new SqlDataAdapter("Select * from Cargo Where CargoCodigo=" + codigo, conectar);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }
    }
}
