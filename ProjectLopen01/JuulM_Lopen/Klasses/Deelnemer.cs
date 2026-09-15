using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuulM_Lopen
{
    internal class Deelnemer
    {
        //JuulMoens
        //11/09/2026
        //Project Lopen

        //Velden + Properties
        String _naam { get; set; } = "";
        int _afstand { get; set; } = 0;
        bool _betaald { get; set; } = false;

        //Functies
        //neemt alle gegevens en zet deze om naar tekst
        public String AlleGegevens()
        {
            string antwoord = "";

            antwoord = $"Deelnemer: {_naam}, loopt {_afstand} kilometer, ";
            if (_betaald)
            {
                antwoord += $"en heeft betaald";
            }
            else
            {
                antwoord += $"en heeft NIET betaald";
            }

            return antwoord;
        }
        //toont welke afstan een bepaalde loper heeft en of hij betaald heeft
        public String AfstEnBetaald() 
        {
            string antwoord = "";
            antwoord = $"gekozen afstand {_afstand}km, ";
            if (_betaald)
            {
                antwoord += $"heeft betaald";
            }
            else 
            {
                antwoord += $"heeft NIET betaald";
            }

            return antwoord;

        }
        //constructors
        //default constructor

        public Deelnemer() { }

        public Deelnemer(string ontvNaam, int ontvAfst, bool ontvBetaald) 
        {
            _naam = ontvNaam;
            _afstand = ontvAfst;
            _betaald = ontvBetaald;
        
        }
    }

}