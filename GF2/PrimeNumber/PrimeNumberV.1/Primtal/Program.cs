using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primtal
{
    class Program
    {

        /*
        OpGave
        Udskriv alle Primtal indenfor rammen af int32 
        Start med < 1000
        */
        [STAThread]
        static void Main(string[] args)
        {
            ArrayList Primtal = new ArrayList();

            Primtal.Add(2);  // 2 er et primtal.

            // Vi løber igennem de mulige primtal, og springer samtlige de lige tal over.
            for (int MuligtPrimtal = 3; MuligtPrimtal <= 100; MuligtPrimtal += 2)
            {
                // Tallet er et primtal indtil det modsatte er bevist.
                bool ErEtPrimtal = true;

                /*  Hvis tallet ikke er et primtal, må mindst en af dividenderne
                    være mindre end kvadratroden af tallet. Der er derfor ikke nogen
                    grund til at undersøge dividender, som er større end kvadratroden.
                */
                int MaksDividend = (int)Math.Floor(Math.Sqrt(MuligtPrimtal));

                /*   Når vi tjekker de mulige dividender, er det ikke nødvendigt at
                     teste for andet end primtal-dividender. Desuden kan vi springe
                     primtallet 2 over idet tallet - pga. den ydre løkke - altid er ulige.
                */
                for (int PrimtalIdx = 1; PrimtalIdx < Primtal.Count; PrimtalIdx++)
                {
                    // Tjek for denne dividend.
                    int Dividend = (int)Primtal[PrimtalIdx];

                    // Hvis den er større end MaksDividend er der ingen grund til
                    // at fortsætte løkken.
                    if (Dividend > MaksDividend) break;

                    // Går dividenden op i tallet?
                    if (MuligtPrimtal % Dividend == 0)
                    {
                        ErEtPrimtal = false;  // Ja! Dermed er tallet ikke et primtal.
                        break;  // ... og der er ingen grund til at fortsætte løkken.
                    }
                }

                // Hvis tallet kom helskinnet igennem løkken er det et primtal.
                if (ErEtPrimtal) Primtal.Add(MuligtPrimtal);
            }

            // Udskriv de fundne primtal.
            foreach (int EtPrimtal in Primtal)
            {
                Console.WriteLine(EtPrimtal);

                Console.WriteLine(Primtal.ToArray(typeof(int)).GetLength(0));
            }
        }

    }
}