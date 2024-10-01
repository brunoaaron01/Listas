namespace Listas
{
    public partial class Listita : Form
    {
        public Listita()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            Ejercicio9 lista = new Ejercicio9();

           
            foreach (char c in input)
            {
                lista.Agregar(c);
            }

           
            string reversed = lista.Invertir();

            
            listBox1.Items.Clear();

            
            foreach (char c in reversed)
            {
                listBox1.Items.Add(c.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
