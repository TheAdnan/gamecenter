using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gameCenter;

namespace gameCenter
{
	public class Igrica {
		private string Naziv ;
		private string Sifra ;
		private Platform Platforma ;
		private kategorije Kategorija ;
		private bool Trailer ;
		private int Dostupnost ;
		private double Cijena ;
		public Igrica(){
		}
		public bool DaLiJeDostupna(int Dostupnost){
		}
		public string DajKategoriju(){
		}
		public string DajPlatformu(){
		}
		public string GenerisiSifru(){
		}
		public void ObracunajPopust(TipoviRegistracije tip_kupca){
		}
	}
}