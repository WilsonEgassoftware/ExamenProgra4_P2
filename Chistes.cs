using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra4_P2
{
    class Chistes : ContentPage
    {


        public Chistes()
        {
            InitializeComponent();
            Title = "Chistes";

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void CargarChistes()
        {
            try
            {
                var cliente = new HttpClient();
                var chistes = await cliente.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
            }
            catch
            {
                ChistesLabel.Text = "Error al cargar el chiste. Inténtalo de nuevo más tarde.";

            }

        }
        private void ChistesLabel_Clicked(object sender, EventArgs e)
        {
            CargarChistes();
        }

        public class ChistesLabel
        {
            public static string Text { get; internal set; }
            public string setup { get; internal set; }
            public string punchline { get; internal set; }
        }

    }   }
