using System;
using System.Collections.Generic;
public class Compte
{
    private int numero;
    private string nom;
    private double solde;
    private double montant;

    public Compte()
    {
        this.numero = 0;
        this.nom = "";
        this.solde = 0;
        this.montant = 0;
    }
    public Compte(int numero, string nom, double solde, double montant)
    {
        this.numero = numero;
        this.nom = nom;
        this.solde = solde;
        this.montant = montant;
    }
    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }
    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    public double Solde
    {
        get { return solde; }
        set { solde = value; }
    }
    public double Montant
    {
        get { return montant; }
        set { montant = value; }
    }
    public double CrediterCompte(double montant)
    {
        this.solde += montant;
        return this.solde;
    }

    public double DebiterCompte(double montant)
    {
        this.solde -= montant;
        return this.solde;
    }
    public double Transferer(Compte c1, Compte c2, double montant)
    {
        c1.DebiterCompte(montant);
        c2.CrediterCompte(montant);
    }

    public double Superieur()
    {

    }
    public void Afficher()
    {
        Console.WriteLine("Le numéro du compte est " + this.Numero + "/nLe nom du propriétaire est " + this.Nom + "/nLe solde est " + this.Solde + "/nLe montant est " + this.Montant);
    }
}