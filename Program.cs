using Gyakjuhasz;
using System.Text;

List<Versenyzo> versenyzok = new List<Versenyzo>();

StreamReader sr = new("ub2017egyedi.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    versenyzok.Add(new Versenyzo(sr.ReadLine()));
}
sr.Close();

Console.WriteLine($"1. feladat: {versenyzok.Count}");