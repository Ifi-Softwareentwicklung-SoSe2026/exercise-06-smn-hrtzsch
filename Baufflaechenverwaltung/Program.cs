using System;
using System.Collections.Generic;

namespace Baufflaechenverwaltung
{
    public enum FlaechenStatus { Frei, Reserviert, Bebaut }
    public enum BauvorhabenStatus { AntragEingereicht, Genehmigt, Abgelehnt, InBearbeitung, Abgeschlossen }

    public class Antragsteller
    {
        public string Name { get; set; } = string.Empty;
        public string Kontaktdaten { get; set; } = string.Empty;
        public string Firma { get; set; } = string.Empty;
    }

    public class Bauflaeche
    {
        public string Id { get; set; } = string.Empty;
        public double Groesse { get; set; }
        public string Lage { get; set; } = string.Empty;
        public string AktuelleNutzung { get; set; } = string.Empty;
        public string Bebaubarkeit { get; set; } = string.Empty;
        public string BPlanNummer { get; set; } = string.Empty;
        public decimal Bodenrichtwert { get; set; }
        public string Eigentuemer { get; set; } = string.Empty;
        public FlaechenStatus Status { get; set; } = FlaechenStatus.Frei;

        public void FlaecheReservieren()
        {
            Status = FlaechenStatus.Reserviert;
        }

        public void StatusAktualisieren(FlaechenStatus neuerStatus)
        {
            Status = neuerStatus;
        }
    }

    public class Grundstueck
    {
        public string FlurstueckNummer { get; set; } = string.Empty;
        public List<Bauflaeche> Bauflaechen { get; set; } = new List<Bauflaeche>();
    }

    public class Bauvorhaben
    {
        public string Titel { get; set; } = string.Empty;
        public Antragsteller Antragsteller { get; set; } = new Antragsteller();
        public string GeplanteNutzung { get; set; } = string.Empty;
        public DateTime Beginn { get; set; }
        public DateTime Fertigstellung { get; set; }
        public BauvorhabenStatus Status { get; set; } = BauvorhabenStatus.AntragEingereicht;
        public List<Bauflaeche> ZugeordneteFlaechen { get; set; } = new List<Bauflaeche>();

        public void StatusAktualisieren(BauvorhabenStatus neuerStatus)
        {
            Status = neuerStatus;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Demonstration
            var grundstueck = new Grundstueck { FlurstueckNummer = "0015 00012 001/002" };
            var flaeche1 = new Bauflaeche 
            {
                Id = "F1", 
                Groesse = 500, 
                Lage = "Nordseite", 
                AktuelleNutzung = "Brachfläche", 
                Bebaubarkeit = "ja", 
                BPlanNummer = "BP-2022-089", 
                Bodenrichtwert = 500m, 
                Eigentuemer = "Max Mustermann"
            };
            grundstueck.Bauflaechen.Add(flaeche1);

            var antragsteller = new Antragsteller { Name = "Erika Musterfrau", Firma = "Bau AG", Kontaktdaten = "erika@bauag.de" };
            
            Console.WriteLine($"Fläche Status vor Reservierung: {flaeche1.Status}");
            flaeche1.FlaecheReservieren();
            Console.WriteLine($"Fläche Status nach Reservierung: {flaeche1.Status}");

            var vorhaben = new Bauvorhaben
            {
                Titel = "Neubau Wohnhaus",
                Antragsteller = antragsteller,
                GeplanteNutzung = "Wohngebäude",
                Beginn = DateTime.Now.AddMonths(1),
                Fertigstellung = DateTime.Now.AddMonths(12),
                Status = BauvorhabenStatus.AntragEingereicht
            };
            vorhaben.ZugeordneteFlaechen.Add(flaeche1);

            Console.WriteLine($"Bauvorhaben '{vorhaben.Titel}' angelegt. Status: {vorhaben.Status}");
            vorhaben.StatusAktualisieren(BauvorhabenStatus.Genehmigt);
            Console.WriteLine($"Status aktualisiert auf: {vorhaben.Status}");
        }
    }
}