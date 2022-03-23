using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
            double altura2 = double.Parse(Altura.Text);
            double peso2 = double.Parse(Peso.Text);

            double imc = peso2 / (altura2 * altura2);

            DisplayAlert("Resultado", "O seu IMC é de: " + imc, "OK");


            if (imc <= 18.5)
            {
                DisplayAlert("Você está com o Peso Baixo", "OK", "SAIR");

            }
            else if (18.5 <= imc && imc <= 24.9)
            {
                DisplayAlert("Você está com o Peso Normal", "OK", "SAIR");

            }
            else if (25.0 <= imc && imc <= 29.9)
            {
                DisplayAlert("Você está com excesso de Peso", "OK", "SAIR");

            }
            else if (30.0 <= imc && imc <= 34.9)
            {
                DisplayAlert("Obesidade Classe I", "OK", "SAIR");

            }
            else if (35.0 <= imc && imc <= 39.9)
            {
                DisplayAlert("Obesidade Classe II", "OK", "SAIR");

            }
            else if (40.0 <= imc && imc <= 40.0) 
            {
                DisplayAlert("Obesidade Clase III", "OK", "SAIR");

            }
        }
    }
}
