namespace Ej5Palindromos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cadena = textBox1.Text; 
            char[] arrayOriginal = cadena.ToCharArray();
            Array.Reverse(arrayOriginal);
            char[] arrayInverso = arrayOriginal;
            if (cadena == new string(arrayInverso))
            {
                label1.Text = "Es un palindromo";
            }
            else
            {
                label1.Text = "No es un palindromo";
            }
        }
    }
    
}