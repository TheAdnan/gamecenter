public class Klijent : Osoba{
	private TipoviRegistracije Tip_registracije ;
	private TipKlijenta Tip_klijenta ;
	private string[0..*] Subscriptions ;
	public Klijent(){
	}
	~Klijent(){
	}
	public TipoviRegistracije TipRegistracije(){
	}
	public void Odjavi(){
	}
	public real Naplata(Igrica[0..*] narudzba){
	}
	public void Subscribe(Platform platforma){
	}
}
