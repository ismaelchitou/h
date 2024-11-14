using System;
using System.Data;

namespace MauiAppCalculatrice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Supp(object sender, EventArgs e)
        {
            expLabel.Text = "";
        }

        private void Button_Clicked_Egale(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(expLabel.Text))
            {
                // Pour évaluer une expression mathématique
                DataTable dt = new DataTable();
                var v = dt.Compute(expLabel.Text, "");
                expLabel.Text = $"{v}";
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            expLabel.Text += "1";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            expLabel.Text += "2";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            expLabel.Text += "3";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
