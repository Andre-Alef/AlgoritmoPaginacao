using System;
using System.Windows.Forms;
using System.Linq.Expressions;
namespace SubstituicaoDePaginas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            int[] Paginas = new int[5] { 0, 0, 0, 0, 0 };
            int[] Sequencia = new int[21] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 , 15, 16, 17, 18, 19, 20, 21};
            int ContadorPaginas = 0;
            int Falta = 0;
            //Array.ForEach(ms, txt.Text);
            foreach (var item in Sequencia)
            {
                txtArray.Text += item.ToString() + ", ";
            }

            //Laço de repetição pelo tamanho da sequencia
            for (int i = 0; i < Sequencia.Length; i++)
            {

                //Verifica se o contador de paginas já está igual o tamanho de paginas
                if (ContadorPaginas == Paginas.Length)
                {
                    //Caso o contador de paginas tenha atingido o numero de paginas, o contador é reiniciado
                    // e é adicionada uma falta de pagina
                    ContadorPaginas = 0;
                    Falta++;   
                    
                }
                //Define que o valor de uma pagina é igual a um numero da sequencia.
                Paginas[ContadorPaginas] = Sequencia[i];

                // Garante que uma Falta de página não seja contada mais de uma vez
                if (Falta > 0 && ContadorPaginas != 0)
                    Falta++;

                if (Falta > 0)
                    txt.Text += Environment.NewLine + Paginas[0].ToString() + " " + Paginas[1].ToString() + " " + Paginas[2].ToString() + " " 
                        + Paginas[3].ToString() + " " + Paginas[4].ToString() + "   |   " + Falta.ToString();
                else
                    txt.Text += Environment.NewLine + Paginas[0].ToString() + " " + Paginas[1].ToString() + " " + Paginas[2].ToString() + " " +
                        Paginas[3].ToString()+ " "+ Paginas[4].ToString();

                ContadorPaginas++;
            }

            //Setar o texto do Total de faltas
            txtTotal.Text= Falta.ToString();

        }



    }
}
