using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization; // crear
using System.IO; // Escribir
using System.Drawing.Text;

namespace Tabla_de_Notas
{
    public partial class Form1 : Form
    {
        //Declarar objetos
        //ArrayList listaAlumnos = new ArrayList();

        List<Alumno> listaAlumnos = new List<Alumno>();
        ValidarCajas validacion = new ValidarCajas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:/net/listaAlumnos.xml"))
            {
                listaAlumnos.Clear();
                XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
                FileStream leerXml = File.OpenRead("C:/net/listaAlumnos.xml");
                listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }

            dgtablaDatos.DataSource = null;
            dgtablaDatos.DataSource = listaAlumnos;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgtablaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsAddUser_Click(object sender, EventArgs e)
        {
            //---------------- Agregar Alumno

            if (!validacion.Vacio(txtcodigoIn, errorM, "El código no puede ser vacío"))
                if (validacion.TipoNumero(txtcodigoIn, errorM, "Debe digitar numeros"))
                    if (!validacion.Vacio(txtnombreIn, errorM, "El nombre no puede ser vacío"))
                        if (validacion.TipoTexto(txtnombreIn, errorM, "Debe digitar letras"))
                            if (!validacion.Vacio(txtcorreoIn, errorM, "El correo no puede ser vacío"))
                                if (validacion.TipoCorreo(txtcorreoIn, errorM, "El correo no cumple con el formato"))
                                    if (!validacion.Vacio(txtNota1, errorM, "La Nota 1 no puede estar vacía"))
                                        if (validacion.TipoNumero(txtNota1, errorM, "Debe digitar numeros"))
                                            if (!validacion.Vacio(txtNota2, errorM, "La Nota 2 no puede estar vacía"))
                                                if (validacion.TipoNumero(txtNota2, errorM, "Debe digitar numeros"))
                                                    if (!validacion.Vacio(txtNota3, errorM, "La Nota 3 no puede estar vacía"))
                                                        if (validacion.TipoNumero(txtNota3, errorM, "Debe digitar numeros"))
                                                            if (!validacion.Vacio(txtNota4, errorM, "La Nota 4 no puede estar vacía"))
                                                                if (validacion.TipoNumero(txtNota4, errorM, "Debe digitar numeros"))
                                                                {
                                                                    if(!ExisteCodigo(Convert.ToInt32(txtcodigoIn.Text)))
                                                                    {
                                                                        insertardatos();
                                                                        LimpiarCajas();
                                                                        errorM.Clear();
                                                                    }
                                                                    else
                                                                    {
                                                                        errorM.SetError(txtcodigoIn, "El código ya existe");
                                                                        txtcodigoIn.Focus();
                                                                        return;
                                                                    }
                                                                }


                                                                    
        }
        //---------- metodo para ver el array en consola
        private void verArreglo()
        {
            foreach (Alumno itemalumno in listaAlumnos)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(itemalumno.Codigo);
                Console.WriteLine(itemalumno.Nombre);
                Console.WriteLine(itemalumno.Correo);
                Console.WriteLine(itemalumno.Nota1);
                Console.WriteLine(itemalumno.Nota2);
                Console.WriteLine(itemalumno.Nota3);
                Console.WriteLine(itemalumno.Nota4);
                Console.WriteLine(itemalumno.NotaFinal);
                Console.WriteLine(itemalumno.NotaConcepto);
                Console.WriteLine("---------------");
            }
        }

        private void tsSaveFile_Click(object sender, EventArgs e)
        {
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("C:/net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

        private void tsOpenFile_Click(object sender, EventArgs e)
        {
            //cargar los datos del xml
            //generar una lista con esos datos
            // mostrar esa lista en el DG

            listaAlumnos.Clear();
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            FileStream leerXml = File.OpenRead("C:/net/listaAlumnos.xml");
            listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
            leerXml.Close();

            dgtablaDatos.DataSource = null;
            dgtablaDatos.DataSource = listaAlumnos;

        }
        private void insertardatos()
        {
            Alumno nuevoAlumno = new Alumno();

            // Desde los elementos del formulario creo el alumno nuevo
            nuevoAlumno.Codigo = Convert.ToInt32(txtcodigoIn.Text);
            nuevoAlumno.Nombre = txtnombreIn.Text;
            nuevoAlumno.Correo = txtcorreoIn.Text;
            nuevoAlumno.Nota1 = Convert.ToDouble(txtNota1.Text);
            nuevoAlumno.Nota2 = Convert.ToDouble(txtNota2.Text);
            nuevoAlumno.Nota3 = Convert.ToDouble(txtNota3.Text);
            nuevoAlumno.Nota4 = Convert.ToDouble(txtNota4.Text);
            nuevoAlumno.NotaFinal = (nuevoAlumno.Nota1 + nuevoAlumno.Nota2 + nuevoAlumno.Nota3 + nuevoAlumno.Nota4) / 4;
            if (nuevoAlumno.NotaFinal >= 3.5)
                nuevoAlumno.NotaConcepto = "Aprobado";
            else
                nuevoAlumno.NotaConcepto = "Reprobado";
            //--------------------------------------

            listaAlumnos.Add(nuevoAlumno);
            dgtablaDatos.DataSource = null;
            dgtablaDatos.DataSource = listaAlumnos;
        }

        private void LimpiarCajas()
        {
            txtcodigoIn.Clear();
            txtnombreIn.Clear();
            txtcorreoIn.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtcodigoIn.Focus();
        }

        private void LimpiarCajas2()
        {
            
            txtnombreIn.Clear();
            txtcorreoIn.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtcodigoIn.Focus();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("C:/net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

        //vamos a usar metodos para la validación y manipulacion de datos
        // validar que el nuevo codigo no exista en la lista

       
        //*******************************************************
        private void tsSearchUser_Click(object sender, EventArgs e)
        {

            // vamos a buscar a un alumno
            // validar que no esté vacio

            if (!validacion.Vacio(txtcodigoIn, errorM, "Para buscar, debe ingresar un código"))
                if (validacion.TipoNumero(txtcodigoIn, errorM, "Debe digitar numeros"))
                {
                    if (ExisteCodigo(Convert.ToInt32(txtcodigoIn.Text)))
                    {
                        Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoIn.Text));
                        txtnombreIn.Text = myAlumno.Nombre;
                        txtcorreoIn.Text = myAlumno.Correo;
                        txtNota1.Text = myAlumno.Nota1.ToString();
                        txtNota2.Text = myAlumno.Nota2.ToString();
                        txtNota3.Text = myAlumno.Nota3.ToString();
                        txtNota4.Text = myAlumno.Nota4.ToString();

                        tsEditUser.Enabled = true;
                        tsDeleteUser.Enabled = true;
                        txtcodigoIn.Enabled = false;

                    }
                    else
                    {
                        errorM.SetError(txtcodigoIn, "El código no existe");
                        txtcodigoIn.Focus();
                        LimpiarCajas2();
                        return;                        
                    }
                
            }

        }
        private Alumno obtenerDatos (int codigo)
        {
            foreach (Alumno myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                    return myAlumno;
            }
            return null;
        }

        private Boolean ExisteCodigo(int codigo)
        {
            foreach (Alumno myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                    return true;
            }
            return false;
        }

        private void tsEditUser_Click(object sender, EventArgs e)
        {
            // editar usuario
            
                    if (!validacion.Vacio(txtnombreIn, errorM, "El nombre no puede ser vacío"))
                        if (validacion.TipoTexto(txtnombreIn, errorM, "Debe digitar letras"))
                            if (!validacion.Vacio(txtcorreoIn, errorM, "El correo no puede ser vacío"))
                                if (validacion.TipoCorreo(txtcorreoIn, errorM, "El correo no cumple con el formato"))
                                    if (!validacion.Vacio(txtNota1, errorM, "La Nota 1 no puede estar vacía"))
                                        if (validacion.TipoNumero(txtNota1, errorM, "Debe digitar numeros"))
                                            if (!validacion.Vacio(txtNota2, errorM, "La Nota 2 no puede estar vacía"))
                                                if (validacion.TipoNumero(txtNota2, errorM, "Debe digitar numeros"))
                                                    if (!validacion.Vacio(txtNota3, errorM, "La Nota 3 no puede estar vacía"))
                                                        if (validacion.TipoNumero(txtNota3, errorM, "Debe digitar numeros"))
                                                            if (!validacion.Vacio(txtNota4, errorM, "La Nota 4 no puede estar vacía"))
                                                                if (validacion.TipoNumero(txtNota4, errorM, "Debe digitar numeros"))
                                                                
                                                            guardarcambios();
                                                                
            //--------------------------------------
        }


        

        private void guardarcambios()
        {
            // metodo crea un objeto alumno con el "codigo que está en la caja de texto correspondiente"  
            // como el objeto es de la lista, actualiza los valores
            Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoIn.Text));
            myAlumno.Nombre = txtnombreIn.Text;
            myAlumno.Correo = txtcorreoIn.Text;
            myAlumno.Nota1 = Convert.ToDouble(txtNota1.Text);
            myAlumno.Nota2 = Convert.ToDouble(txtNota2.Text);
            myAlumno.Nota3 = Convert.ToDouble(txtNota3.Text);
            myAlumno.Nota4 = Convert.ToDouble(txtNota4.Text);

            myAlumno.NotaFinal = (myAlumno.Nota1 + myAlumno.Nota2 + myAlumno.Nota3 + myAlumno.Nota4) / 4;
            if (myAlumno.NotaFinal >= 3.5)
            {
                myAlumno.NotaConcepto = "Aprobado";
            }
            else
            {
                myAlumno.NotaConcepto = "Reprobado";
            }

            dgtablaDatos.DataSource = null;
            dgtablaDatos.DataSource = listaAlumnos;

            tsEditUser.Enabled = false;
            tsDeleteUser.Enabled = false;
            txtcodigoIn.Enabled = true;
            LimpiarCajas();

        }

                private void tsDeleteUser_Click(object sender, EventArgs e)
        {
            // borrar datos del estudiante

            DialogResult confirmarborrar = MessageBox.Show("¿Está seguro de borrar estos datos?","Confirmar borrado",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (confirmarborrar == DialogResult.OK)
            {
                Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoIn.Text));
                listaAlumnos.Remove(myAlumno);

                dgtablaDatos.DataSource = null;
                dgtablaDatos.DataSource = listaAlumnos;

                tsEditUser.Enabled = false;
                tsDeleteUser.Enabled = false;
                txtcodigoIn.Enabled = true;
                LimpiarCajas();
            }
        }
    }


}

