using EJ1.Models;

namespace EJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Estancia Estancia { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Estancia = new Estancia("Mi Estancia", "C1", 1500);
            Estancia.casco.Administrador = "Jorge";
        }
    }
}
