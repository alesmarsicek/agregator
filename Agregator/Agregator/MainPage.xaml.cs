using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace Agregator
{
	public partial class MainPage : ContentPage
	{
        Dictionary<String,String> basicCategories = new Dictionary<String,String>{
            {"warning", "Havárie" },
            {"stop","Plánované odstávky" },
            {"trafficlight", "Doprava" },
            {"network", "Akce" },
            {"cloudy","Počasí" },
            {"lightbulb", "Místní informace" }
        };
        int counter = 0;
        public MainPage()
		{
			InitializeComponent();

            BasicGrid.HeightRequest = App.height * 0.6;
            BasicGrid.Margin = new Thickness(0, App.height * 0.05, 0, App.height * 0.05);
            

            foreach (var Name in basicCategories)
            {
                RowDefinition rw = new RowDefinition();
                Label lb = new Label();
                lb.Text = Name.Value;
                Grid.SetColumn(lb, 1);

                CheckBox chb = new CheckBox();
                chb.DefaultText = Name.Value;

                Image img = new Image();// { Aspect = Aspect.AspectFit };
                img.Source = ImageSource.FromFile(CreatePath(Name.Key));

                Grid.SetRow(img, counter);
                Grid.SetRow(chb, counter);

                Grid.SetColumn(img, 1);
                Grid.SetColumn(chb, 0);

                BasicGrid.Children.Add(img);
                BasicGrid.Children.Add(chb);
                

                counter++;

            }

            Button bt = new Button();
            bt.Text = "Uložit nastavení";
            Grid.SetRow(bt, counter);
            BasicGrid.Children.Add(bt);
        }

        private void SaveSettings(object sender, EventArgs e)
        {

        }

        private string CreatePath(String img)
        {
            return "Resources/images/" + img + ".png";
        }

       
	}
}
