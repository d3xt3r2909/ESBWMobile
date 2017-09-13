﻿using ESBX_MyPLC.Models;
using ESBX_MyPLC.Util;
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
	public partial class PodesavanjeLozinke : ContentPage
	{
        private WebAPIHelper profilService = new WebAPIHelper("http://hci148.app.fit.ba/", "api/Korisnici");
        private HelperPassword h = new HelperPassword();

        Korisnici k=Global.logedUser;

		public PodesavanjeLozinke ()
		{
			InitializeComponent ();
		}

        

        private void SacuvajPass_Clicked()
        {

            if (k.LozinkaHash == HelperPassword.GenerateHash(trenutniPass.Text, k.LozinkaSalt))
            {
                if(noviPass.Text!=null && noviPass.Text.Equals("") && noviPass.Text == noviPassTwo.Text)
                {
                    k.LozinkaHash = HelperPassword.GenerateHash(noviPass.Text, k.LozinkaSalt);

                    HttpResponseMessage responseMessage = profilService.PutResponse(k.Id, k);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        DisplayAlert("Uspjeh", "Uspješno ste promijenili lozinku!", "OK");
                    }
                    else
                    {
                        DisplayAlert("Upozorenje",responseMessage.ReasonPhrase, "OK");
                    }

                    
                }
                else
                {
                    DisplayAlert("Upozorenje", "Provjerite novu lozinku!", "OK");
                }
            }
            else
            {
                DisplayAlert("Upozorenje", "Provjerite trenutnu lozinku!", "OK");
            }
        }
    }
}