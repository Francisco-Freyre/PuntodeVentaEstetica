using LinqToDB;
using PuntodeVentaEstetica.Connection;
using PuntodeVentaEstetica.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica.Controller
{
    class Usuario : Conexion
    {
        private TextBox textBox1, textBox2, textBox3, textBox4;
        private Label label1, label2, label3, label4;
        private DataGridView dataGridView;
        private static int idUsuario, pageSize = 15;
        private static String accion = "insert";

        public Usuario(object[] textBox, object[] labels, DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            textBox1 = (TextBox)textBox[0];
            textBox2 = (TextBox)textBox[1];
            textBox3 = (TextBox)textBox[2];
            textBox4 = (TextBox)textBox[3];
            label1 = (Label)labels[0];
            label2 = (Label)labels[1];
            label3 = (Label)labels[2];
            label4 = (Label)labels[3];
        }
        public List<usuarios> getUsuarios()
        {
            return usuarios.ToList();
        }

        public void searchUsuarios(DataGridView dataGridView, string campo)
        {
            IEnumerable<usuarios> query;
            if (campo.Equals(""))
            {
                query = usuarios.ToList();
            }
            else
            {
                query = usuarios.Where(p => p.nombre.StartsWith(campo) || p.apellido.StartsWith(campo) || p.usuario.StartsWith(campo));
            }
            dataGridView.DataSource = query.ToList();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView.Columns[4].Visible = false;
        }

        public void restablecerUsuarios()
        {
            idUsuario = 0;
            accion = "insert";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            label1.ForeColor = Color.LightSlateGray;
            label1.Text = "Nombre:";
            label2.ForeColor = Color.LightSlateGray;
            label2.Text = "Apellidos:";
            label3.ForeColor = Color.LightSlateGray;
            label3.Text = "Usuario:";
            label4.ForeColor = Color.LightSlateGray;
            label4.Text = "Contraseña:";
            searchUsuarios(dataGridView, "");
        }

        internal bool registrarUsuario()
        {
            bool valor = false;

            if (textBox1.Text == "")
            {
                label1.Text = "Ingrese el nombre";
                label1.ForeColor = Color.Red;
                textBox1.Focus();
            }
            else
            {
                if (textBox2.Text == "")
                {
                    label2.Text = "Ingrese el Apellido";
                    label2.ForeColor = Color.Red;
                    textBox2.Focus();
                }
                else
                {
                    if (textBox3.Text == "")
                    {
                        label3.Text = "Ingrese el usuario";
                        label3.ForeColor = Color.Red;
                        textBox3.Focus();
                    }
                    else
                    {
                        if (textBox4.Text == "")
                        {
                            label4.Text = "Ingrese la contraseña";
                            label4.ForeColor = Color.Red;
                            textBox4.Focus();
                        }
                        else
                        {
                            var listUsuario = usuarios.Where(u => u.usuario.Equals(textBox3.Text)).ToList();
                            if (listUsuario.Count == 1)
                            {
                                if (idUsuario ==listUsuario[0].idUsuario)
                                {
                                    valor = true;
                                    ejecutar();
                                }
                                else
                                {
                                    if (idUsuario != listUsuario[0].idUsuario)
                                    {
                                        label3.Text = "El usuario ya existe";
                                        label3.ForeColor = Color.Red;
                                        textBox3.Focus();
                                        valor = false;
                                    }
                                }

                            }
                            else
                            {
                                if (listUsuario.Count == 0)
                                {
                                    valor = true;
                                    ejecutar();
                                }
                                else
                                {
                                    valor = false;
                                    ejecutar();
                                }
                            }
                        }
                    }
                }
            }
            void ejecutar()
            {
                if (valor == true)
                {
                    guardarUsuario();
                }
            }
            return valor;
        }

        private void guardarUsuario()
        {
            var pass = Encriptar.EncryptData(textBox4.Text, textBox3.Text);
            switch (accion)
            {
                case "insert":

                   usuarios.Value(u => u.nombre, textBox1.Text)
                           .Value(u => u.apellido, textBox2.Text)
                           .Value(u => u.usuario, textBox3.Text)
                           .Value(u => u.contrasenia, pass)
                           .Insert();

                    break;
                case "update":
                   usuarios.Where(u => u.idUsuario.Equals(idUsuario))
                            .Set(u => u.nombre, textBox1.Text)
                            .Set(u => u.apellido, textBox2.Text)
                            .Set(u => u.usuario, textBox3.Text)
                            .Set(u => u.contrasenia, pass)
                            .Update();
                    break;
            }
        }

        public void dataGridViewUsuarios()
        {
            accion = "update";
            idUsuario = Convert.ToInt16(dataGridView.CurrentRow.Cells[0].Value);
            textBox1.Text = Convert.ToString(dataGridView.CurrentRow.Cells[1].Value);
            textBox2.Text = Convert.ToString(dataGridView.CurrentRow.Cells[2].Value);
            textBox3.Text = Convert.ToString(dataGridView.CurrentRow.Cells[3].Value);
            String pass = Convert.ToString(dataGridView.CurrentRow.Cells[4].Value);
            textBox4.Text = Encriptar.DecryptData(pass, textBox3.Text);
        }

        public void eliminarUsuario(int idUsuario)
        {
            usuarios.Where(u => u.idUsuario.Equals(idUsuario)).Delete();
        }
    }
}
