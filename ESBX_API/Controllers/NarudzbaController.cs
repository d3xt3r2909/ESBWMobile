﻿using ESBX_db.DAL;
using ESBX_db.Helper;
using ESBX_db.Models;
using ESBX_db.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ESBX_API.Controllers
{
    public class NarudzbaController : ApiController
    {
        MContext ctx = new MContext();

        [HttpGet]
        [Route("api/Narudzba/GetTrenutneNarudzbe/{KorisnikId}")]
        public IHttpActionResult GetTrenutneNarudzbe(string KorisnikId)
        {
            int korId = Convert.ToInt32(KorisnikId);
            List<NarudzbeVM> listSalata = new List<NarudzbeVM>();
            //DODAJ ONE AKTIVNA, ZAVRSENA ATRIBUTE
            int KorpaId = ctx.Korpa.Where(x => x.KorisnikId == korId).Select(x=>x.Id).FirstOrDefault();
            UkupnaCijenaVM model = new UkupnaCijenaVM();
            model.listaSalataId = ctx.KorpaStavke.Where(y => y.KorpaId == KorpaId).Select(p => new ListaVrijednostiVM
            {
                SalataId = p.SalataId,
                Kolicina = p.Kolicina
            }).ToList();

            foreach(var i in model.listaSalataId)
            {
                NarudzbeVM n = new NarudzbeVM();
                n.SalataId = i.SalataId;
                n.Kolicina = i.Kolicina.ToString();
                List<String> nazivi = ctx.SalataStavke.Where(x => x.SalataId == i.SalataId).Select(y => y.Sastojak.Naziv).ToList();
                foreach(var k in nazivi)
                {
                    n.Sastojci += k + ",";
                }
                n.Sastojci=n.Sastojci.Remove(n.Sastojci.Length - 1, 1);
                List<float> cijene= ctx.SalataStavke.Where(x => x.SalataId == i.SalataId).Select(y => y.Sastojak.Cijena).ToList();
                float UkupnoOdSastojaka=0;
                foreach (var k in cijene)
                {
                   UkupnoOdSastojaka += k ;
                }
                n.Cijena = (UkupnoOdSastojaka * i.Kolicina).ToString();
                listSalata.Add(n);
            }


            return Ok(listSalata);
        }


        //GetHistorijaNarudzbe
        [HttpGet]
        [Route("api/Narudzba/GetHistorijaNarudzbe/{KorisnikId}")]
        public IHttpActionResult GetHistorijaNarudzbe(string KorisnikId)
        {
            int korId = Convert.ToInt32(KorisnikId);
            List<NarudzbeVM> listSalata = new List<NarudzbeVM>();
            //DODAJ ONE AKTIVNA, ZAVRSENA ATRIBUTE
            List<int> korpaIds = ctx.Korpa.Where(x => x.KorisnikId == korId).Select(x => x.Id).ToList();
            
            foreach(var korpaId in korpaIds)
            {
                List<int> SalataIds = ctx.KorpaStavke.Where(y => y.KorpaId == korpaId).Select(p => p.SalataId).ToList();
               
                foreach (var i in SalataIds)
                {
                    NarudzbeVM n = new NarudzbeVM();
                    n.SalataId = i;
                    List<String> nazivi = ctx.SalataStavke.Where(x => x.SalataId == i).Select(y => y.Sastojak.Naziv).ToList();
                    foreach (var k in nazivi)
                    {
                        n.Sastojci += k + ",";
                    }
                    n.Sastojci = n.Sastojci.Remove(n.Sastojci.Length - 1, 1);
                    List<float> cijene = ctx.SalataStavke.Where(x => x.SalataId == i).Select(y => y.Sastojak.Cijena).ToList();
                    float UkupnoOdSastojaka = 0;
                    foreach (var k in cijene)
                    {
                        UkupnoOdSastojaka += k;
                    }
                    n.Cijena = UkupnoOdSastojaka.ToString();
                    listSalata.Add(n);
                }

            }
            
            return Ok(listSalata);
        }

        [HttpPost]
        public IHttpActionResult PostSalata(NarudzbeVM Salata)
        {
            int saladId = Convert.ToInt32(Salata.SalataId);
            if (Salata != null)
            {
                #region DodavanjeSalateUKorpu
                
                // Pretraga za korpom, da li korpa korisnika vec postoji i da li je ona aktivna 
                Korpa k = ctx.Korpa.FirstOrDefault(x => x.Aktivna && x.Korisnik.Email == System.Web.HttpContext.Current.User.Identity.Name);

                // Ukoliko korisnik nema korpu, potrebno je kreirati novu i aktivirati je
                if (k == null)
                {
                    // Inicijalizacija nove korpe
                    k = new Korpa
                    {
                        KorisnikId = 10,
                        //VRATI
                        //AccountHelper.GetUserId(System.Web.HttpContext.Current.User.Identity.Name),
                        Zavrsena = false,
                        Aktivna = true,
                        VrijemeDolaska = DateTime.Now,
                        VrijemeNarucivanja = DateTime.Now,
                        Sifra = Constants.GenerateUniqueKod(9)
                    };
                    ctx.Korpa.Add(k);
                    // Spasavanje promijena
                    ctx.SaveChanges();
                }
                    
                    

                    KorpaStavke ks = new KorpaStavke
                    {
                        KorpaId = k.Id,
                        SalataId = saladId,
                        Kolicina = 1
                    };

                    // Dodavanje u tabelu stavki korpe 
                    ctx.KorpaStavke.Add(ks);

                    // Snimanje promijena
                    ctx.SaveChanges();

                #endregion

                return Ok();
                }
            else
            {
                return BadRequest();
            }


        }
    }
}
