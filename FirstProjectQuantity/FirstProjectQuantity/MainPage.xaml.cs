using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstProjectQuantity
{
    public partial class MainPage : ContentPage
    {
        private int quantidade = 0;
        public MainPage()
        {
            InitializeComponent();
            number_quantidade.Text = quantidade.ToString();
            if (quantidade == 0)
            {
                button_drop.IsEnabled = false;
            }
        }

        private void add_quantidade(object sender, EventArgs e)
        {
            quantidade += 1;
            number_quantidade.Text = quantidade.ToString();
            if (quantidade > 0)
            {
                button_drop.IsEnabled = true;
            }
        }

        private void drop_quantidade(object sender, EventArgs e)
        {
            if (quantidade == 0)
            {
                button_drop.IsEnabled = false;
            }
            else {
                button_drop.IsEnabled = true;
                quantidade -= 1;
                number_quantidade.Text = quantidade.ToString();
                button_drop.IsEnabled = quantidade == 0 ? false : button_drop.IsEnabled; 
            }
        }
    }
}
