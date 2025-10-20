using AufgabenBlatt03_Aufgabe06.Modelle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TextWritingSchüler("Schüler");
            TextWritingProjekte("Projekte");

            List<Schüler> klasse = new List<Schüler>();
            List<Projekt> allProjekte = new List<Projekt>();
            Projekt mostWanted;

            klasse = CreatePeopleList();
            allProjekte = CreateProjektList(klasse);

            mostWanted = GetMostWantedPrject(allProjekte);

        }

        static Projekt GetMostWantedPrject(List<Projekt> getMostWanted)
        {
            int maxTeilnehmer = 0;
            int currentTeilnehmer = 0;
            for(int i = 0; i < getMostWanted.Count; i++)
            {
                currentTeilnehmer = getMostWanted[i].TeilnehmerAnzahl();
                if(maxTeilnehmer < currentTeilnehmer)
                {
                    maxTeilnehmer = currentTeilnehmer;
                }
            }
            return getMostWanted[maxTeilnehmer];
        }

        static List<Schüler> CreatePeopleList()
        {
            List<string> peopleRaw = new List<string>();
            List<Schüler> klasse = new List<Schüler>();
            peopleRaw = ReadText("Schüler");

            for (int i = 0; i < peopleRaw.Count; i++)
            {
                string[] butcher = peopleRaw[i].Split(':');
                int saveId;
                int.TryParse(butcher[0], out saveId);
                Schüler schüler = new Schüler(saveId,butcher[1]);
                klasse.Add(schüler);
            }

            return klasse;
        }

        static List<Projekt> CreateProjektList(List<Schüler> klasse)
        {
            List<string> projekteRaw = new List<string>();
            List<Projekt> allProjekte = new List<Projekt>();
            List<Schüler> teilnehmer = new List<Schüler>();
            projekteRaw = ReadText("Projekte");

            for (int i = 0; i < projekteRaw.Count; i++)
            {
                string[] butcher = projekteRaw[i].Split(':');
                char saveId = char.Parse(butcher[0]);

                string[] butcherNum = butcher[2].Split(',');

                for(int j = 0; j<butcherNum.Length; j++)
                {
                    for(int k = 0; k < klasse.Count; k++)
                    {
                        if(j == klasse[k].GetId())
                        {
                            teilnehmer.Add(klasse[k]);
                        }
                    }
                }

                Projekt projekt = new Projekt(saveId, butcher[1],teilnehmer);
                allProjekte.Add(projekt);
            }

            return allProjekte;
        }

        static List<string> ReadText(string file)
        {
            string path = $@"C:\Users\ITA4-TN12\Desktop\Datein\Aufgaben\TextDatein\{file}.txt";

            FileStream lesen = new FileStream(path, FileMode.Open);
            StreamReader l = new StreamReader(lesen);

            List<string> TextRaw = new List<string>();

            do 
            {
                TextRaw.Add(l.ReadLine());
            }while (l.ReadLine() == null);

            return TextRaw;
        }

        static void TextWritingSchüler(string file)
        {
            string path = $@"C:\Users\ITA4-TN12\Desktop\Datein\Aufgaben\TextDatein\{file}.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter s = new StreamWriter(fs);

            s.WriteLine("1:Thomas Mayer");
            s.WriteLine("2:Anne Müller");
            s.WriteLine("3:Richard Schwab");
            s.WriteLine("4:Rainer Schütter");
            s.WriteLine("5:Hans Lau");
            s.WriteLine("6:Christina Herbers");
            s.WriteLine("7:Karla Meier");
            s.WriteLine("8:Antonia Huber");
            s.WriteLine("9:Angela Marx");
            s.WriteLine("10:Emma Schöpe");
            s.WriteLine("11:Sven Gans");
            s.WriteLine("12:Peter Lustig");
            s.WriteLine("13:Michael Schneider");
            s.WriteLine("14:Max Schäfer");

            s.Close();
        }

        static void TextWritingProjekte(string file)
        {
            string path = $@"C:\Users\ITA4-TN12\Desktop\Datein\Aufgaben\TextDatein\{file}.txt";

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter s = new StreamWriter(fs);

            s.WriteLine("A:SQL Datenbanken:1,2,3,4,5,12");
            s.WriteLine("B:Linux:6,5,4,3,2,11,12,13,14");
            s.WriteLine("C:Windows 7:1,14");
            s.WriteLine("D:OOP in C#:3,4,5,6,10,13");
            s.WriteLine("E:Fußball:1,2,3,4,5,10,11,12");

            s.Close();
        }
    }
}
