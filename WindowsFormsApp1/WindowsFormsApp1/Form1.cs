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
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Registro nuevoregistro = new Registro();
        public Form1(Registro minuevoregistro)
        {
            InitializeComponent();
            nuevoregistro = minuevoregistro;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;

            

            panel1.BringToFront();
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            string nombreusuario = textBoxNombreUsuario.Text;
            Usuario nuevousuario = new Usuario(nombreusuario);
            nuevoregistro.AgregarUsuario(nuevousuario);

            textBoxUsuario.AppendText(nombreusuario);

            panel2.BringToFront();
            pictureBox33.Image = Image.FromFile("C:pacman-right.png");
            
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            timerfrutas.Interval = 30000;
            timerfrutas.Start();

            timerDesaparecer.Interval = 10000;
            timerDesaparecer.Start();

            
        }

        private void timerfrutas_Tick(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            
            int filarandom = rnd.Next(1, 6);
            int columnarandom = rnd.Next(1, 6);

            int filarandom1 = rnd.Next(1, 5);
            int columnarandom1 = rnd.Next(1, 6);

            
            //Para cherry
            //columna 1
            if (filarandom == 1 & columnarandom == 1)
            {
                pictureBox11.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 2 & columnarandom == 1)
            {
                pictureBox12.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 3 & columnarandom == 1)
            {
                pictureBox13.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 4 & columnarandom == 1)
            {
                pictureBox14.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 5 & columnarandom == 1)
            {
                pictureBox15.Image = Image.FromFile("C:cherry.png");
            }
            //columna 2
            if (filarandom == 1 & columnarandom == 2)
            {
                pictureBox21.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 2 & columnarandom == 2)
            {
                pictureBox22.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 3 & columnarandom == 2)
            {
                pictureBox23.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 4 & columnarandom == 2)
            {
                pictureBox24.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 5 & columnarandom == 2)
            {
                pictureBox25.Image = Image.FromFile("C:cherry.png");
            }

            //columna 3
            if (filarandom == 1 & columnarandom == 3)
            {
                pictureBox31.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 2 & columnarandom == 3)
            {
                pictureBox32.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 3 & columnarandom == 3)
            {
                pictureBox33.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 4 & columnarandom == 3)
            {
                pictureBox34.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 5 & columnarandom == 3)
            {
                pictureBox35.Image = Image.FromFile("C:cherry.png");
            }
            //columna 4
            if (filarandom == 1 & columnarandom == 4)
            {
                pictureBox41.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 2 & columnarandom == 4)
            {
                pictureBox42.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 3 & columnarandom == 4)
            {
                pictureBox43.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 4 & columnarandom == 4)
            {
                pictureBox44.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 5 & columnarandom == 4)
            {
                pictureBox45.Image = Image.FromFile("C:cherry.png");
            }
            //columna 5
            if (filarandom == 1 & columnarandom == 5)
            {
                pictureBox51.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 2 & columnarandom == 5)
            {
                pictureBox52.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 3 & columnarandom == 5)
            {
                pictureBox53.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 4 & columnarandom == 5)
            {
                pictureBox54.Image = Image.FromFile("C:cherry.png");
            }
            if (filarandom == 5 & columnarandom == 5)
            {
                pictureBox55.Image = Image.FromFile("C:cherry.png");
            }

            //Para uva
            //columna 1
            if (filarandom1 == 1 & columnarandom1 == 1)
            {
                pictureBox11.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 2 & columnarandom1 == 1)
            {
                pictureBox12.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 3 & columnarandom1 == 1)
            {
                pictureBox13.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 4 & columnarandom1 == 1)
            {
                pictureBox14.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 5 & columnarandom1 == 1)
            {
                pictureBox15.Image = Image.FromFile("C:tile114.png");
            }
            //columna 2
            if (filarandom1 == 1 & columnarandom1 == 2)
            {
                pictureBox21.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 2 & columnarandom1 == 2)
            {
                pictureBox22.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 3 & columnarandom1 == 2)
            {
                pictureBox23.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 4 & columnarandom1 == 2)
            {
                pictureBox24.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 5 & columnarandom1 == 2)
            {
                pictureBox25.Image = Image.FromFile("C:tile114.png");
            }

            //columna 3
            if (filarandom1 == 1 & columnarandom1 == 3)
            {
                pictureBox31.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 2 & columnarandom1 == 3)
            {
                pictureBox32.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 3 & columnarandom1 == 3)
            {
                pictureBox33.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 4 & columnarandom1 == 3)
            {
                pictureBox34.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 5 & columnarandom1 == 3)
            {
                pictureBox35.Image = Image.FromFile("C:tile114.png");
            }
            //columna 4
            if (filarandom1 == 1 & columnarandom1 == 4)
            {
                pictureBox41.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 2 & columnarandom1 == 4)
            {
                pictureBox42.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 3 & columnarandom1 == 4)
            {
                pictureBox43.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 4 & columnarandom1 == 4)
            {
                pictureBox44.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 5 & columnarandom1 == 4)
            {
                pictureBox45.Image = Image.FromFile("C:tile114.png");
            }
            //columna 5
            if (filarandom1 == 1 & columnarandom1 == 5)
            {
                pictureBox51.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 2 & columnarandom1 == 5)
            {
                pictureBox52.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 3 & columnarandom1 == 5)
            {
                pictureBox53.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 4 & columnarandom1 == 5)
            {
                pictureBox54.Image = Image.FromFile("C:tile114.png");
            }
            if (filarandom1 == 5 & columnarandom1 == 5)
            {
                pictureBox55.Image = Image.FromFile("C:tile114.png");
            }
        }

        private void timerDesaparecer_Tick(object sender, EventArgs e)
        {
            if (pictureBox11.Image == Image.FromFile("C:tile114.png") | pictureBox11.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox11.Image = null;
                pictureBox11.Image.Dispose();
            }
            if (pictureBox21.Image == Image.FromFile("C:tile114.png") | pictureBox21.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox21.Image = null;
                pictureBox21.Image.Dispose();
            }
            if (pictureBox31.Image == Image.FromFile("C:tile114.png") | pictureBox31.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox31.Image = null;
                pictureBox31.Image.Dispose();
            }
            if (pictureBox41.Image == Image.FromFile("C:tile114.png") | pictureBox41.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox41.Image = null;
                pictureBox41.Image.Dispose();
            }
            if (pictureBox51.Image == Image.FromFile("C:tile114.png") | pictureBox51.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox51.Image = null;
                pictureBox51.Image.Dispose();
            }

            if (pictureBox12.Image == Image.FromFile("C:tile114.png") | pictureBox12.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox12.Image = null;
                pictureBox12.Image.Dispose();
            }
            if (pictureBox22.Image == Image.FromFile("C:tile114.png") | pictureBox22.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox22.Image = null;
                pictureBox22.Image.Dispose();
            }
            if (pictureBox32.Image == Image.FromFile("C:tile114.png") | pictureBox32.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox32.Image = null;
                pictureBox32.Image.Dispose();
            }
            if (pictureBox42.Image == Image.FromFile("C:tile114.png") | pictureBox42.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox42.Image = null;
                pictureBox42.Image.Dispose();
            }
            if (pictureBox52.Image == Image.FromFile("C:tile114.png") | pictureBox52.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox52.Image = null;
                pictureBox52.Image.Dispose();
            }

            if (pictureBox13.Image == Image.FromFile("C:tile114.png") | pictureBox13.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox13.Image = null;
                pictureBox13.Image.Dispose();
            }
            if (pictureBox23.Image == Image.FromFile("C:tile114.png") | pictureBox23.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox23.Image = null;
                pictureBox23.Image.Dispose();
            }
            if (pictureBox33.Image == Image.FromFile("C:tile114.png") | pictureBox33.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox33.Image = null;
                pictureBox33.Image.Dispose();
            }
            if (pictureBox43.Image == Image.FromFile("C:tile114.png") | pictureBox43.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox43.Image = null;
                pictureBox43.Image.Dispose();
            }
            if (pictureBox53.Image == Image.FromFile("C:tile114.png") | pictureBox53.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox53.Image = null;
                pictureBox53.Image.Dispose();
            }

            if (pictureBox14.Image == Image.FromFile("C:tile114.png") | pictureBox14.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox14.Image = null;
                pictureBox14.Image.Dispose();
            }

            if (pictureBox24.Image == Image.FromFile("C:tile114.png") | pictureBox24.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox24.Image = null;
                pictureBox24.Image.Dispose();
            }
            if (pictureBox34.Image == Image.FromFile("C:tile114.png") | pictureBox34.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox34.Image = null;
                pictureBox34.Image.Dispose();
            }
            if (pictureBox44.Image == Image.FromFile("C:tile114.png") | pictureBox44.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox44.Image = null;
                pictureBox44.Image.Dispose();
            }
            if (pictureBox54.Image == Image.FromFile("C:tile114.png") | pictureBox54.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox54.Image = null;
                pictureBox54.Image.Dispose();
            }

            if (pictureBox15.Image == Image.FromFile("C:tile114.png") | pictureBox15.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox15.Image = null;
                pictureBox15.Image.Dispose();
            }
            if (pictureBox25.Image == Image.FromFile("C:tile114.png") | pictureBox25.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox25.Image = null;
                pictureBox25.Image.Dispose();
            }
            if (pictureBox35.Image == Image.FromFile("C:tile114.png") | pictureBox35.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox35.Image = null;
                pictureBox35.Image.Dispose();
            }
            if (pictureBox45.Image == Image.FromFile("C:tile114.png") | pictureBox45.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox45.Image = null;
                pictureBox45.Image.Dispose();
            }
            if (pictureBox55.Image == Image.FromFile("C:tile114.png") | pictureBox55.Image == Image.FromFile("C:cherry.png"))
            {
                pictureBox55.Image = null;
                pictureBox55.Image.Dispose();
            }
        }

        private void buttonPausa_Click(object sender, EventArgs e)
        {
            timerfrutas.Stop();

            timerDesaparecer.Stop();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Write);
                bin.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            else
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Create, FileAccess.Write);
                bin.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            Application.Exit();
        }
    }
}
