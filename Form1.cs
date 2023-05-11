namespace Aplicacion_estudiantes
{
    public partial class Form1 : Form
    {
        Estudiantes[] estudiantes = new Estudiantes[5]; // solo 5 estudiantes
        int contador = 0;
        bool verificado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            if (contador < 5)
            {
                bool verificado = true;
                if (txtbCarnet.Text == "")
                {
                    lblErrorCarnet.Text = "El carnet no puede ser vacío";
                    lblErrorCarnet.Visible = true;
                    verificado = false;
                }
                if (txtbNombre.Text == "")
                {
                    lblErrorNombre.Text = "El carnet no puede ser vacío";
                    lblErrorNombre.Visible = true;
                    verificado = false;
                }
                if (verificado)
                {
                    lblErrorNombre.Visible = false;
                    lblErrorCarnet.Visible = false;
                    estudiantes[contador] = new Estudiante(txtbNombre.Text, txtbCarnet.Text);
                    contador++;

                    txtbCarnet.Text = "";
                    txtbNombre.Text = "";

                }


            }
            else
            {
                lblError.Text = "No es posible almacenar estudiante";
                lblError.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // si 
       
      

        private void clinic(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == (char)Keys.Enter)
                {


                    if (contador < 5)
                    {
                        bool verificado = true;
                        if (txtbCarnet.Text == "")
                        {
                            lblErrorCarnet.Text = "El carnet no puede ser vacío";
                            lblErrorCarnet.Visible = true;
                            verificado = false;
                        }
                        if (txtbNombre.Text == "")
                        {
                            lblErrorNombre.Text = "El carnet no puede ser vacío";
                            lblErrorNombre.Visible = true;
                            verificado = false;
                        }
                        if (verificado)
                        {
                            lblErrorNombre.Visible = false;
                            lblErrorCarnet.Visible = false;
                            estudiantes[contador] = new Estudiante(txtbNombre.Text, txtbCarnet.Text);
                            contador++;

                            txtbCarnet.Text = "";
                            txtbNombre.Text = "";

                        }


                    }
                    else

                    {

                        lblError.Text = "No es posible almacenar estudiante";
                        lblError.Visible = true;
                    }
                }

            }


        }

        private void clinic1(object sender, KeyPressEventArgs e)
        {

      

                if (e.KeyChar == (char)Keys.Enter)
                {


                    if (contador < 5)
                    {
                        bool verificado = true;
                        if (txtbCarnet.Text == "")
                        {
                            lblErrorCarnet.Text = "El carnet no puede ser vacío";
                            lblErrorCarnet.Visible = true;
                            verificado = false;
                        }
                        if (txtbNombre.Text == "")
                        {
                            lblErrorNombre.Text = "El carnet no puede ser vacío";
                            lblErrorNombre.Visible = true;
                            verificado = false;
                        }
                        if (verificado)
                        {
                            lblErrorNombre.Visible = false;
                            lblErrorCarnet.Visible = false;
                            estudiantes[contador] = new Estudiante(txtbNombre.Text, txtbCarnet.Text);
                            contador++;

                            txtbCarnet.Text = "";
                            txtbNombre.Text = "";

                        }


                    }
                    else

                    {

                        lblError.Text = "No es posible almacenar estudiante";
                        lblError.Visible = true;
                    }
                }

            }
    }
    }
