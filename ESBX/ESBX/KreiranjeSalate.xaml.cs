﻿using ESBX_MyPLC.Models;
using ESBX_MyPLC.Util;
using ESBX_MyPLC.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESBX
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KreiranjeSalate : ContentPage
	{
        Sastojci glavni;
        Sastojci dresing;
        int Kol = 1;
        string Nap = "";
        SelectMultipleBasePage<Sastojci>  multiPage=null;
        private WebAPIHelper kreiranjeService = new WebAPIHelper("http://hci148.app.fit.ba/", "api/KreiranjeSalate");
		public KreiranjeSalate ()
		{
			InitializeComponent ();
		}
        
        private void btnDodajUKorpu_Clicked(object sender, EventArgs e)
        {
            if (multiPage != null)
            {
                List<Sastojci> izabrani = multiPage.GetSelection();
                glavni= (Sastojci)GlavniPicker.SelectedItem;
                dresing= (Sastojci)DresingPicker.SelectedItem;
                izabrani.Add(glavni);
                izabrani.Add(dresing);
                List<int> SastojciIds = new List<int>();
                foreach(Sastojci i in izabrani)
                {
                    SastojciIds.Add(i.Id);
                }
                if (SastojciIds != null)
                {
                    KreiranaSalataVM k = new KreiranaSalataVM
                    {
                        listaIzabranih=SastojciIds,
                        Kolicina = Convert.ToInt32(Kolicina.Text),
                        Napomena = Napomena.Text
                };
                    HttpResponseMessage repsoneDodaj= kreiranjeService.PostResponse(k);
                    if (repsoneDodaj.IsSuccessStatusCode)
                    {
                        
                        DisplayAlert("Uspjeh", "Uspješno ste kreirali salatu.", "OK");
                        GlavniPicker.SelectedIndex = -1;
                        glavni = null;
                        DresingPicker.SelectedIndex = -1;
                        dresing = null;
                        Kol = 1;
                        Kolicina.Text = "1";
                        Nap = "";
                        Napomena.Text = "";

                    }
                    else
                    {
                        DisplayAlert("Oprez", "Salata nije kreirana.", "OK");
                    }
                }
            }
           
            
        }
        protected override void OnAppearing()
        {
            HttpResponseMessage repsoneGlavni = kreiranjeService.GetResponse(1);
            if (repsoneGlavni.IsSuccessStatusCode)
            {
                var jsonResult = repsoneGlavni.Content.ReadAsStringAsync();
                List<Sastojci> listG = JsonConvert.DeserializeObject<List<Sastojci>>(jsonResult.Result);
                GlavniPicker.ItemsSource = listG;
                GlavniPicker.ItemDisplayBinding = new Binding("Naziv");
            }



            HttpResponseMessage repsoneDresing = kreiranjeService.GetResponse(3);
            if (repsoneDresing.IsSuccessStatusCode)
            {
                var jsonResult = repsoneDresing.Content.ReadAsStringAsync();
                List<Sastojci> listD = JsonConvert.DeserializeObject<List<Sastojci>>(jsonResult.Result);
                DresingPicker.ItemsSource = listD;
                DresingPicker.ItemDisplayBinding = new Binding("Naziv");
            }

            if (glavni != null)
            {
                GlavniPicker.SelectedIndex = glavni.Id;
            }
            if (dresing != null)
            {
                DresingPicker.SelectedIndex = dresing.Id;
            }
            if (Kol != 1)
            {
                Kol =  Convert.ToInt32(Kolicina.Text);
            }
            else
            {
                Kolicina.Text="1";
            }
            if (Nap != null)
            {
                Nap = Napomena.Text;
            }

            base.OnAppearing();
        }


        protected override void OnDisappearing()
        {
            glavni = (Sastojci)GlavniPicker.SelectedItem;
            dresing = (Sastojci)DresingPicker.SelectedItem;
        }

            private void btnSporedni_Clicked()
        {
            List<Sastojci> sporedni = new List<Sastojci>();
             HttpResponseMessage repsone = kreiranjeService.GetResponse(2);
            if (repsone.IsSuccessStatusCode)
            {
                var jsonResult = repsone.Content.ReadAsStringAsync();
                sporedni = JsonConvert.DeserializeObject<List<Sastojci>>(jsonResult.Result);

            }
            
            multiPage = new SelectMultipleBasePage<Sastojci>(sporedni);          
            Navigation.PushAsync(multiPage);          
        }
        


    }
}
    