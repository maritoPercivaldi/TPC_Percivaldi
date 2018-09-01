using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace negocio
{
    public partial class clsBaseBusiness
    {

        public string BaseDeDatos { get; set; }
        public SqlConnection conexion { get; set; }
        public SqlCommand commando { get; set; }
        public string CadenaConexion { get; set; }
        public SqlDataReader lector { get; set; }
        
        //pensar y hablar con maxi
        //public clsBaseBusiness preparar(string db, SqlConnection conn, SqlCommand comm, string server, SqlDataReader lect)
        //{
            
        //}

        //public clsBaseBusiness()
        //{
        //    BaseDeDatos = "ksrPanel";
        //    CadenaConexion = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog=" + BaseDeDatos + ";Integrated Security=SSPI";
        //}





        //public void Conectar()
        //{
        //    string connetionString = null;
        //    SqlConnection cnn;
        //    connetionString = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog=ksrPanel;Integrated Security=SSPI";
        //    cnn = new SqlConnection(connetionString);
        //    try
        //    {
        //        cnn.Open();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //{
        //    string connetionstring = null;
        //sqlconnection cnn;
        //connetionstring = "data source=servername;initial catalog=databasename;user id=username;password=password"
        //    cnn = new sqlconnection(connetionstring);
        //    try
        //    {
        //        cnn.open();
        //        messagebox.show("connection open ! ");
        //        cnn.close();
        //    }
        //    catch (exception ex)
        //    {
        //        messagebox.show("can not open connection ! ");
        //    }
        //}
    }
}
