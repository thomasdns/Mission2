using System;
using System.Collections.Generic;

public class Banque
{
	private Compte mesComptes = new List<Compte>();
	
	public Banque(List<Compte> mesComptes)
	{
		this.mesComptes = mesComptes;
	}

	public List<Compte> MesComptes
	{
		get { return this.mesComptes; }
		set { this.mesComptes = value; }
	}
	public double AjoutCompte(Compte c)
	{
		;
	}
	public double CompteMax()
	{
	}

}