//Standardbefehle werden aufgerufen:
using System;
using System.Globalization;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Markup;
//Ausführung für Peripheriegeräte:
using System.IO;
using System.Data;
//Console.WriteLine("4. \t Sportler speichern");
using System.Text;
using System.Drawing;
//using System.Array;
//using System.Math;
using System.Resources;
//Ausgabeverzögerung von Daten mit ThreadSleep(1000); für eine Sekunde:
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Channels;
//.NET 5 benötigt eine weiterer Systembibliothek für List(); wobei (); hier Funktion bedeutet
using System.Web;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.DynamicInterfaceCastableImplementationAttribute;
using static System.Runtime.InteropServices.JavaScript.JSType;
//Dictionary-Befehl und kvp key value product wird aufgerufen:
using System.Collections.ObjectModel;
using System.Collections.Generic;
//using System.Collections.Generic.IEnumerables;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace step2coder_ConsoleApp_3HU
{
    internal class SportlerClass1
    {
        //Attribute mit Eigenschaften einer Klasse deklarieren:
        public string name;
        public string nachname;
        public string vorname;
        public string geb_dat;

        public double laufdaten;
        public double factor;

        public double distance;
        public double height;
        public double calculate;

        //Basiskonstruktor:
        public SportlerClass1()
        {
            //Eigenschaften einer Klasse definieren:
            name = "Nachname und Vorname";

            //Zum Einlesen der Attribute im Hauptprogramm Program.cs:
            nachname = "Muster";
            vorname  = "Max";

            //Zusätzlicher Denkschritt zur Suche der Sportlerdaten:
            geb_dat = "01.01.1900";

            //Definition der Sportdaten zur Leistungsberechnung:
            laufdaten   = 0.00;
            factor      = 0.00;
            distance    = 0.00;
            height      = 0.00;
            calculate   = 0.00;
        }
        //Attribute von Klasse Name und Geburtsdatum:
        public SportlerClass1(string _name, string _geb_dat)
        {
            name = _name;
            geb_dat = _geb_dat;
        }
        //Wie in der Schulübung zu Kundendaten besprochen mit die get-Funktion in Klasse SportlerClass1:
        public string get_SportlerClass1 ()
        {
            return name;
        }
        //set-Klassenfunktion SportlerClass1.cs zum Eintrag in Hauptprogramm Program.cs:
        public void set_SportlerClass1(string _nachname, string _vorname, double _factor)
        {
            nachname = _nachname;
            vorname = _vorname;
            factor = _factor;
        }
        //Attribute von Klasse Sportfaktor werden durch Werte im Hauptprogramm überschrieben:
        public SportlerClass1(double _distance, double _height, double _laufdaten, double _factor)
        {
            laufdaten = _laufdaten;
            factor = _factor;

            distance = _distance;
            height = _height;
        }
        //Methode als Funktion innerhalb einer Klasse
        public void laufen(double _distance, double _height)
        {
            //Console.WriteLine("Wie weit bist heute gelaufen?");
            //distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Du bist heute\t  " + distance + "m gelaufen.\n");
            //Zeilennummer ab 100 kurze Erklärungen dieser mathematischen Funktionen
            calculate = Math.Round(Math.Sqrt(distance) * Math.Exp(height) * Math.Pow(height,2), 2);
            //Console.WriteLine(Math.Pow(4, 0.5)); andere Wurzel den Bruch vorher berechnen hier Quadratwurzel 0.5 = 1/2
            Console.WriteLine("Der Leistungsfaktor lautet:\t  " + calculate);
        }
        //Methode ohne static (Bezug auf Klasse ohne Aufruf) zum Ausgeben:
        public void print_data()
        {
            // \t mit Tabulator und \r als carriage return:
            //Console.WriteLine("\nName:" + "\t   " + name);
            Console.WriteLine("\nNachname:" + "\t   " + nachname);
            Console.WriteLine("\nVorname:"  + "\t   " + vorname);
            Console.WriteLine("\nFaktor:"   + "\t   " + factor);
            //Ende public void
        }
        //Ende internal class SportlerClass1
    }
    //Ende namespace 
}
/*
 * 
 * Console.WriteLine(Math.Pow(4, (1 / 2))); liefert falsches ergebnis zuerst bruch für beliebige wurzel berechnen
 * 
 * * Math.Exp(height); https://learn.microsoft.com/de-de/dotnet/api/system.math.exp?view=net-8.0
 * Hinweise
e ist eine mathematische Konstante, deren Wert ungefähr 2,71828 ist.

Verwenden Sie die Pow -Methode, um die Kräfte anderer Grundlagen zu berechnen.

Exp ist die Inverse von Log.

Diese Methode ruft die zugrunde liegende C-Runtime auf, und das genaue Ergebnis oder der gültige Eingabebereich kann sich zwischen verschiedenen Betriebssystemen oder Architekturen unterscheiden.

 * 
 * https://learn.microsoft.com/de-de/dotnet/api/system.math.sqrt?view=net-8.0
 * 
 * https://learn.microsoft.com/de-de/dotnet/api/system.math.round?view=net-8.0
 * 
 * 
 * https://learn.microsoft.com/de-de/dotnet/api/system.math.pow?view=net-8.0
 * 
int value = 2;
for (int power = 0; power <= 32; power++)
   Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");

// The example displays the following output:
//     2^0 = 1 (0x1)
//     2^1 = 2 (0x2)
//     2^2 = 4 (0x4)
//     2^3 = 8 (0x8)
//     2^4 = 16 (0x10)
//     2^5 = 32 (0x20)
//     2^6 = 64 (0x40)
//     2^7 = 128 (0x80)
//     2^8 = 256 (0x100)
//     2^9 = 512 (0x200)
//     2^10 = 1,024 (0x400)
//     2^11 = 2,048 (0x800)
//     2^12 = 4,096 (0x1000)
//     2^13 = 8,192 (0x2000)
//     2^14 = 16,384 (0x4000)
//     2^15 = 32,768 (0x8000)
//     2^16 = 65,536 (0x10000)
//     2^17 = 131,072 (0x20000)
//     2^18 = 262,144 (0x40000)
//     2^19 = 524,288 (0x80000)
//     2^20 = 1,048,576 (0x100000)
//     2^21 = 2,097,152 (0x200000)
//     2^22 = 4,194,304 (0x400000)
//     2^23 = 8,388,608 (0x800000)
//     2^24 = 16,777,216 (0x1000000)
//     2^25 = 33,554,432 (0x2000000)
//     2^26 = 67,108,864 (0x4000000)
//     2^27 = 134,217,728 (0x8000000)
//     2^28 = 268,435,456 (0x10000000)
//     2^29 = 536,870,912 (0x20000000)
//     2^30 = 1,073,741,824 (0x40000000)
//     2^31 = 2,147,483,648 (0x80000000)
//     2^32 = 4,294,967,296 (0x100000000)
 */