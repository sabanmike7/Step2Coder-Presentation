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
//Viel verwendete Befehle als Übersicht ab der Zeilennummer 500
//Zeilennummer ab 460 befindet sich die individuelle Beschreibung des Programmes

/*
            Programm:       step2coder-ConsoleApp-3HU-Presentation 
            Zweck:          Präsentation am 03. Juli 2024
            Aufgabe:        Verbesserung aufgrund neuer Programmeinschulung
            Autor:          Mirza Sabanovic
            Datum:          25.06.2024
            Änderungen:     Orginaldatei ist step2coder-ConsoleApp-14
            Link:           https://careerfoliospaces.wordpress.com/wp-content/uploads/2024/06/24juni-portfolio.pdf
*/



//Salzburg, am Dienstag den 25.Juni 2024 als Fortsetzung vom 22.Mai 2024 mit Mirza Sabanovic
namespace step2coder_ConsoleApp_3HU
{
    internal class Program
    {
        //Deklaration des globalen Dateiverzeichnisses auf dem USB-Laufwerk:
        //DirectoryInfo[] cDirs = new DirectoryInfo(@"D:\\test.txt").GetDirectories();

        //Definition und Deklaration der globalen Testvariablen:
        public static string testpfad   = @"D:\test.txt";               //Zeilennummer ab 180 und erste  Menüauswahl
                                                                        //Zeilennummer ab 270 und dritte Menüauswahl
        public static string ausgabe    = @"D:\output.txt";             //Zeilennummer ab 200 und zweite Menüauswahl

        //Definition und Deklaration der globalen Variablen:
        public static string seminarpfad    = @"D:\seminar.txt";        //Zeilennummer ab 310 und vierte Menüauswahl
        //Feedback zur Benutzerfreundlichkeit
        public static string benutzerpfad   = @"D:\benutzerfreundlichkeit.txt";
        //Feedback zur implementierten validierung                      //Zeilennummer ab 350 und fünfte Menüauswahl
        public static string feedbackpfad   = @"D:\validierung.txt";    //Zeilennummer ab -    und sechste Menüauswahl


        private static void Main(string[] args)
        {
            //Definition und Deklaration dr lokalen Variablen für das private unveränderliche Haupt-Programm ohne Rückgabewert
            int menue = 0;

            string eingabe  = "";
            string suche    = "";
            string orginalText = "";

            string beenden = "";
            string feedback1 = "\n5.\t  Feedback Benutzerfreundlichkeit: \n";
            string feedback2 = "\n6.\t  Feedback Implementierte Validierung:\n";

            //Definition und Deklaration zum Einlesen der Textdatei:
            string textdatei0 = "";
            string textdatei1 = "";
            string textdatei2 = "";
            string textdatei3 = "";
            string textdatei4 = "\n4.\t Sportler speichern mit Leistungsdaten (Nachname, Vorname, Faktor):\n";
            string textdatei5 = "";         //Zeilennummer ab 370 und fünfte Menüauswahl
            string textdatei6 = "";         //Zeilennummer ab 410 und sechste Menüauswahl

            //Menüauswahl 2 suchen und löschen die Variablen ab Zeilennummer 230
            string menue1factor = "";
            string menue2search = "";
            string menue5user   = "";
            string menue6user   = "";

            //Menüauswahl 3 Sportler auflisten:
            string substring = "";
            //Fehlende Daten in der Eingabe suchen:
            char   character = '0';
            //True oder False bei Result für IF-Statement:
            bool   result = false;

            //Klassenvariablen aus Basiskonstruktur deklariert respektive definiert:
            string name = "";
            string geb_dat = "";

            //Definition und Deklaration der Variablen:
            double laufdaten = 0.00;
            double factor = 0.00;
            double distance = 0.00;
            double height = 0.00;
            double calculate = 0.00;

            //Deklaration der Liste als versuchter Denkschritt
            //List<string> sportler = new List<string>();

            //Vorsicht bei der Suche Großschreibung beachten ist Case Sensitive
            //sportler.Add("Namen, Laufdaten, Faktor");
      
            //Datentyp SportlerClass1 mit Variable attributX:
            SportlerClass1 attribut1 = new SportlerClass1();
            SportlerClass1 attribut2 = new SportlerClass1();
            SportlerClass1 attribut3 = new SportlerClass1();
            SportlerClass1 attribut4 = new SportlerClass1();        //attribut4 für die vierte Menüauswahl 
            //Ein Datensatz als Basis im Hauptprogramm Program.cs für dritte und vierte Menüauswahl:
            attribut3.set_SportlerClass1("Sabanovic", "Mirza", 4000);
            //calculate = distance * height; berechne = 2km Lauf mal 2m Körpergröße

            do
            {
            //Bginn der Sprunganweisung von Using Sysem;
            beginning:
                Console.WriteLine("\n \n \t \t Menü für Mitarbeiterverwaltung einer Sportanalyse\n \n");
                Console.WriteLine("1. \t Sportler einlesen");
                Console.WriteLine("2. \t Suchen und Löschen");
                Console.WriteLine("3. \t Sportler auflisten");
                Console.WriteLine("4. \t Sportler speichern");
                Console.WriteLine("5. \t Feedback Benutzerfreundlichkeit");
                Console.WriteLine("6. \t Feedback Implementierte Validierung");
                Console.WriteLine("7. \t Programm erneut starten");
                Console.WriteLine("8. \t Programm beenden");

                // Optional Sportler sortieren

                Console.WriteLine(" \nBitte Geben Sie eine Menüauswahl ein:");
                menue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\n\n");


                switch (menue)
                {
                    //erste menüauswahl
                    case 1:

                        //2 Sekunden für den Terminierungsvorgang eingerechnet:
                        Thread.Sleep(2000);
                        //Bildschirm gelöscht und wieder auf Menüauswahl geschoben:
                        Console.Clear();

                        Console.WriteLine("\n1.\t   Sportler einlesen:\n");

                        Console.WriteLine("Bitte geben Sie den Nachnamen ein:");
                        attribut1.nachname = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Bitte geben Sie den Vornamen ein:");
                        attribut1.vorname = Convert.ToString(Console.ReadLine());

                        //Console.WriteLine("\n \n Wie lautet das Geburtsdatum (01.01.1900) ?");
                        //attribut1.geb_dat = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Welche Strecke in Meter läufst du heute?");
                        attribut2.distance = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Wie gross bist du in Meter?");
                        attribut2.height = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Dein Leistungsfaktor beträgt:");
                        //Funktionsaufruf aus der Klasse SportlerClass1.cs
                        attribut2.laufen(distance, height);

                        if (File.Exists(testpfad) == true)
                        {
                            textdatei1 = File.ReadAllText(testpfad);
                            //testpfad als globale Variable ab Zeilennummer 60
                            File.AppendAllText(testpfad, "\n\n\n" + attribut1.nachname + "," + attribut1.vorname + ","
                                + attribut1.calculate);
                        }
                        else
                        {
                            Console.WriteLine($"Die Datei {testpfad} wurde nicht gefunden !");
                            Thread.Sleep(2000);
                            goto beginning;
                        }
                       
                        Console.WriteLine("\n\n\n");

                        Console.WriteLine("Mit JA wird regulär beendet:");
                        beenden = Convert.ToString(Console.ReadLine().ToLower());

                        if (beenden == "ja")
                        {
                            //Beendigung des Programmes mit Rückgabewert wie Zeilennummer
                            Environment.Exit(200);
                        }
                        else
                        {
                                //Die Sprungfunktion beginning wird durch goto aktiviert:
                                goto beginning;          
                        }                      
                    break;
                    //zweite menüauswahl
                    case 2:
                        //2 Sekunden für den Terminierungsvorgang eingerechnet:
                        Thread.Sleep(2000);
                        //Bildschirm gelöscht und wieder auf Menüauswahl geschoben:
                        Console.Clear();

                        DirectoryInfo[] cDirs = new DirectoryInfo(@"D:\\test.txt").GetDirectories();
                        Console.WriteLine("\nDer Inhalt des USB-Laufwerkes wird aufgelistet:\n\n");
                        //Verzeichnis auf dem USB-Laufwerk wird ausgegeben:
                        using (StreamWriter sw = new StreamWriter(ausgabe))
                        {
                            foreach (DirectoryInfo dir in cDirs)
                            {
                                sw.WriteLine(dir.Name);
                            }
                        }
                        //Deklaration und Definition ab Zeilennummer 60
                        if (File.Exists(ausgabe) == true)
                        {
                            textdatei2 = File.ReadAllText(ausgabe);
                            
                        }
                        else
                        {
                            Console.WriteLine($"Die Datei {ausgabe} wurde nicht gefunden !");
                            Thread.Sleep(2000);
                            goto beginning;
                        }

                        Console.WriteLine("\n2.\t   Suchen und Löschen:\n");
                        Console.WriteLine("\nBitte geben Sie den Suchbegriff zum Löschen ein:\n");
                        suche = Convert.ToString(Console.ReadLine());

                        if(textdatei2.Contains(suche) == true)
                        {
                            Console.WriteLine($"\t  Die Zeichenkette respektive Wort {suche} wurde gefunden !");
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine(textdatei2);
                        }
                        else
                        {
                            Console.WriteLine($"Die Zeichenkette respektive Wort {suche} wurde nicht gefunden oder falscheingegeben !");
                            Thread.Sleep(2000);
                            goto beginning;
                        }
                        //orginalText wird hier durch StringWriter von using System.Text eingelesen:
                        menue2search = textdatei2.Replace(suche, "");

                        Console.WriteLine($"\t  Die Zeichenkette respektive Wort {suche} wurde gelöscht!");

                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Mit JA wird regulär beendet.");
                        beenden = Convert.ToString(Console.ReadLine().ToLower());

                        if (beenden == "ja")
                        {
                            //Beendigung des Programmes mit Rückgabewert wie Zeilennummer
                            Environment.Exit(270);
                        }
                        else
                        {
                            //Die Sprungfunktion beginning wird durch goto aktiviert:
                            goto beginning;
                        }                      
                    break;
                    //dritte menüauswahl
                    case 3:
                        //2 Sekunden für den Terminierungsvorgang eingerechnet:
                        Thread.Sleep(2000);
                        //Bildschirm gelöscht und wieder auf Menüauswahl geschoben:
                        Console.Clear();
                        //Test der Klassenfunktion SportlerClass1.cs ab Zeilennummer 110
                        attribut3.print_data();

                        Console.WriteLine("\n3.\t   Sportler auflisten:\n");
                        //Deklaration und Definition ab Zeilennummer 60
                        if (File.Exists(testpfad) == true)
                        {
                            textdatei3 = File.ReadAllText(testpfad);
                            Console.WriteLine(textdatei3 + "\n");
                        }
                        else
                        {
                            Console.WriteLine($"Die Datei {testpfad} wurde nicht gefunden !");
                            Thread.Sleep(2000);
                            goto beginning;
                        }

                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Mit JA wird regulär beendet.");
                        beenden = Convert.ToString(Console.ReadLine().ToLower());

                        if (beenden == "ja")
                        {
                                //Beendigung des Programmes mit Rückgabewert wie Zeilennummer
                                Environment.Exit(310);
                        }
                        else
                        {
                                //Die Sprungfunktion beginning wird durch goto aktiviert:
                                goto beginning;
                        }
                    break;                    
                    //vierte menüauswahl
                    case 4:
                        //jetzt gibt es durch mathematische funktionen in SportlerClass1.cs
                        //andere Werte welche weniger mit Distanz mal Körpergröße passen
                        attribut4.set_SportlerClass1("Sabanovic", "Mirza", 4000);       //1321,79   Formel 2000 und 2
                        attribut4.set_SportlerClass1("Muster", "Max", 8000);            //3,14      Formel 4000 und 1.55
                        attribut4.set_SportlerClass1("Mann", "Milian", 12000);          //9.61      Formel 6000 und 1.65

                        //2 Sekunden für den Terminierungsvorgang eingerechnet:
                        Thread.Sleep(2000);
                        //Bildschirm gelöscht und wieder auf Menüauswahl geschoben:
                        Console.Clear();

                        Console.WriteLine("\n4.\t   Sportler speichern:\n");
                        //Console.WriteLine("\nDie Datei output.txt wurde gespeichert:\n\n");

                        if (File.Exists(seminarpfad) == true)
                        {
                            textdatei4 = File.ReadAllText(seminarpfad);
                            //Console.WriteLine(textdatei4 + "\n");
                        }
                        else
                        {
                            Console.WriteLine($"Die Datei {testpfad} wurde nicht gefunden !");
                            Thread.Sleep(2000);
                            goto beginning;
                        }
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Mit JA wird regulär beendet.");
                        beenden = Convert.ToString(Console.ReadLine().ToLower());

                        if (beenden == "ja")
                        {
                            //Beendigung des Programmes mit Rückgabewert wie Zeilennummer
                            Environment.Exit(350);
                        }
                        else
                        {
                            //Die Sprungfunktion beginning wird durch goto aktiviert:
                            goto beginning;
                        }
                    break;
                    //fünfte menüauswahl
                    case 5:
                        //2 Sekunden für den Terminierungsvorgang eingerechnet:
                        Thread.Sleep(2000);
                        //Bildschirm gelöscht und wieder auf Menüauswahl geschoben:
                        Console.Clear();

                        Console.WriteLine("\n5.\t     Feedback Benutzerfreundlichkeit:\n");

                        Console.WriteLine("\nSie haben zehn Sekunden Zeit, bitte geben sie Ihr kurzes Feedback ein:");
                        menue5user = Convert.ToString(Console.ReadLine().ToLower());

                        //Für Feedback hat der Benutzer auch 10 Sekunden Zeit:
                        Thread.Sleep(10000);

                        if (File.Exists(benutzerpfad) == true)
                        {
                            textdatei5 = File.ReadAllText(benutzerpfad);
                            //testpfad als globale Variable ab Zeilennummer 60
                            File.AppendAllText(benutzerpfad, "\n\n\n" + menue5user);
                        }
                        else
                        {
                            Console.WriteLine($"Die Datei {benutzerpfad} wurde nicht gefunden !");
                            Thread.Sleep(2000);
                            goto beginning;
                        }


                        //Funktion .ToLower() wird hier wegen CaseSensitive platziert
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Mit JA wird regulär beendet.");
                        beenden = Convert.ToString(Console.ReadLine().ToLower());

                        if (beenden == "ja")
                        {
                            //Beendigung des Programmes mit Rückgabewert wie Zeilennummer
                            Environment.Exit(400);
                        }
                        else
                        {
                            //Die Sprungfunktion beginning wird durch goto aktiviert:
                            goto beginning;
                        }

                    break;
                    //sechste menüauswahl
                    case 6:
                        Console.WriteLine("\n6.\t     Feedback Implementierte Validierung:\n");

                        Console.WriteLine("\nSie haben zehn Sekunden Zeit, bitte geben sie Ihr kurzes Feedback ein:");
                        menue6user = Convert.ToString(Console.ReadLine().ToLower());

                        //Für Feedback hat der Benutzer auch 10 Sekunden Zeit:
                        Thread.Sleep(10000);

                        if (File.Exists(feedbackpfad) == true)
                        {
                            textdatei6 = File.ReadAllText(feedbackpfad);
                            //testpfad als globale Variable ab Zeilennummer 60
                            File.AppendAllText(feedbackpfad, "\n\n\n" + menue6user);
                        }
                        else
                        {
                            Console.WriteLine($"Die Datei {feedbackpfad} wurde nicht gefunden !");
                            Thread.Sleep(2000);
                            goto beginning;
                        }


                        //Funktion .ToLower() wird hier wegen CaseSensitive platziert
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Mit JA wird regulär beendet.");
                        beenden = Convert.ToString(Console.ReadLine().ToLower());

                        if (beenden == "ja")
                        {
                            //Beendigung des Programmes mit Rückgabewert wie Zeilennummer
                            Environment.Exit(440);
                        }
                        else
                        {
                            //Die Sprungfunktion beginning wird durch goto aktiviert:
                            goto beginning;
                        }
                    break;
                    //siebente menüauswahl
                    //Console.WriteLine("7. \t Programm erneut starten");
                    case 7:
                        //Bildschirm gelöscht und wieder auf Menüauswahl geschoben:
                        Console.Clear();

                        //Die Sprungfunktion beginning wird durch goto aktiviert:
                        goto beginning;
                    //achte menüauswahl
                    case 8:

                        //Bei der Angabe von 8 wird regulär beendet und ungefähre Bereich mit Zeilennummer registriert:
                        Environment.Exit(500);
                    break;

                    default:                      
                        Console.WriteLine("Bitte geben Sie eine Zahl von 1 bis 8 ein !");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Mit JA wird regulär beendet.");
                        beenden = Convert.ToString(Console.ReadLine().ToLower());
                        if (beenden == "ja")
                        {
                            //Beendigung des Programmes mit Rückgabewert wie Zeilennummer
                            Environment.Exit(470);
                        }
                        else
                        {

                            //Hinweis für den Benutzer, dass Programm beendet wird
                            Console.WriteLine("Es wird nicht ordnungsgemäß beendet !");

                            //Mit einem Tippfehler wird Zeilennummer als ungefähre Bereich registriert:
                            Environment.Exit(480);
                        }                   
                    break;
                            //Ende der switch case
                }
                    //Ende der while loop
            } while (beenden == "ja");
        //Ende von static void Main
        }
    //Ende internal class Program
    }
//Ende namespace
}



/*
 * Mitarbeiterverwaltung von einer Sportdatenbank
 * 
 * Erster Versuch gelang erfolgreich mit dem Projekt Step2Coder-ConsoleApp14
 * 
 * Step2Coder-ConsoleApp15 ist hier die Fortsetzung step2coder-ConsoleApp-3HU
 * 
 * und wird für die Präsentation am 03. Juli 2024 vorbereitet
 * 
 * Ich beginne wie der Weiterbildungskurs schon sagt mit kleinen Meilensteinen
 * 
 * damit ich so eine komplexe Aufgabenstellung von Herrn DI(FH) Mag. Dr. Arthur Schuchter, MSc.
 * 
 * besser verstehe. 
 * 
 * Ich führe eine Sportdatenbank anstatt von Büchern einer Bibliothek
 * 
 * und versuche die Beschreibung des Beispiels von Aufgabenstellung umzusetzen.
 * 
 * Drei Szenarien mit 
 * 
 * Hinzufügen und Anzeigen
 * 
 * Suchen und Löschen
 * 
 * Daten nach Sportler auflisten
 * 
 * Klassen um Bücher im Hauptprogramm eine Funktion verwenden
 * 
 * Speichervorgang mit List oder Dictionary 
 * 
 * 
 * Denkversuche mit only hard work pays off erst nach mehrmaligen Versuchen 
 * Unter Menüpunkt Projekt eine Klasse erstellen und mit Liste Funktion arbeiten
 *
 *
 *Viel verwendete Befehle 
 *Console.WriteLine();
 *Funktionsaufruf public void laufen(); 
 *unter SportlerClass1.cs als Klasse
 *
 *Methode von Klasse aufrufen
 *attribut2.laufen(distance);
 *
 *   
            //Console.ReadLine().ToLower(); funktioniert nur in Main selbst bei .NET 8

            //Versuche hier das Verzeichnis zu deklarieren respektive definieren:
            //DirectoryInfo[] cDirs = new DirectoryInfo(@"E:\\output.txt").GetDirectories();
            // Write each directory name to a file and create database output in txt format:
            using (StreamWriter sw = new StreamWriter(@"E\\output.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            Console.WriteLine("\nDie Datei output.txt wird ausgegeben:\n\n");
            if (File.Exists("E:\\output.txt"))
            {
                textdatei0 = File.ReadAllText("E:\\output.txt");
                Console.WriteLine(textdatei0);
            }

            Console.WriteLine("\n\n\n");




                        Console.WriteLine("\n3.\tWelchen Nachnamen, Vornamen, Faktor wollen Sie auflisten ?\n");
                        substring = Convert.ToString(Console.ReadLine());


                        result = textdatei3.Contains(substring);

                        if(result == true)
                        {
                            Console.WriteLine("\n" + substring + "\t   wurde gefunden:\n");
                            Console.WriteLine(textdatei3);
                        }
                        else
                        {
                            Console.WriteLine("\n\t   Leistungsdaten nicht gefunden !\n");
                            Console.WriteLine(textdatei3);
                        }




                        Denkschritt mit Attributen der Klassenfunktion:
                        Console.WriteLine("\n\t Hier wird nach Attribut der Klassenfunktion aufgelistet:\n");
                        Console.WriteLine("\nName:\t        " + attribut1.name);
                        Console.WriteLine("\nGeburtsdatum:\t" + attribut1.geb_dat);
                        






*
*/