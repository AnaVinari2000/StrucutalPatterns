using System;

namespace Composite_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Carte violonistaDeLaAuschwitz = new Carte("Vioara de la Auschwitz");

            Capitol capitol1 = new Capitol("I");
            Capitol capitol2 = new Capitol("II");
            Capitol capitol3 = new Capitol("III");
            Capitol capitol4 = new Capitol("IV");
            Capitol capitol5 = new Capitol("V");
            Capitol capitol6 = new Capitol("VI");
            Capitol capitol7 = new Capitol("VII");
            Capitol capitol8 = new Capitol("VIII");


            violonistaDeLaAuschwitz.AddComponent(capitol1);
            violonistaDeLaAuschwitz.AddComponent(capitol2);
            violonistaDeLaAuschwitz.AddComponent(capitol3);
            violonistaDeLaAuschwitz.AddComponent(capitol4);
            violonistaDeLaAuschwitz.AddComponent(capitol5);
            violonistaDeLaAuschwitz.AddComponent(capitol6);
            violonistaDeLaAuschwitz.AddComponent(capitol7);

            violonistaDeLaAuschwitz.Display();

            Carte creierulCopiluluiTau = new Carte("Creierul Copilului Tau");


            Capitol capitol_1 = new Capitol("I");
            Capitol capitol_2 = new Capitol("II");
            Capitol capitol_3 = new Capitol("III");
            Capitol capitol_4 = new Capitol("IV");
            Capitol capitol_5 = new Capitol("V");
            Capitol capitol_6 = new Capitol("VI");
            Capitol capitol_7 = new Capitol("VII");
            Capitol capitol_8 = new Capitol("VIII");

            creierulCopiluluiTau.AddComponent(capitol_1);
            creierulCopiluluiTau.AddComponent(capitol_2);
            creierulCopiluluiTau.AddComponent(capitol_3);
            creierulCopiluluiTau.AddComponent(capitol_4);
            creierulCopiluluiTau.AddComponent(capitol_5);
            creierulCopiluluiTau.AddComponent(capitol_6);
            creierulCopiluluiTau.AddComponent(capitol_7);

            creierulCopiluluiTau.Display();
        }
    }
}
