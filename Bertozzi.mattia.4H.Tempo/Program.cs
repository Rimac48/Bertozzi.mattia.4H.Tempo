using System;

namespace Bertozzi.mattia._4H.Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma Tempo di Mattia Bertozzi 4H\n");
            //13,50,15
            Tempo T1 = new Tempo();
            Tempo T2 = new Tempo(2,20,45);
            Console.WriteLine($"Primo orario {T1}");
            Console.WriteLine($"Secondo orario {T2}\n");

            Console.WriteLine($"Addizione orari...");
            Console.WriteLine($"\t{T1.SommaTempo(T2)}");

            Console.WriteLine($"Sottrazione orari...");
            Console.WriteLine($"\t{T1.SottraiTempo(T2)}");

            Console.ReadLine();
        }
    }

    class Tempo
    {
        private int _ore;
        private int _minuti;
        private int _secondi;

        public int Ore
        {
            get
            {
                return _ore;
            }
            set
            {
                value = _ore;
            }
        }
        public int Minuti
        {
            get
            {
                return _minuti;
            }

            set
            {
                value = _minuti;
            }
        }

        public int Secondi
        {
            get
            {
                return _secondi;
            }

            set
            {
                value = _secondi;
            }
        }

        public Tempo(int o, int m,int s)
        {
            _ore = o;
            _minuti = m;
            _secondi = s;
        }

        //costruttore di default
        public Tempo()
        {
            _ore = 13;
            _minuti = 50;
            _secondi = 15;
        }

        public string SommaTempo(Tempo t)
        {
            //valori del primo orario (T1)
            int ore1 = this.Ore;
            int minuti1 = this.Minuti;
            int secondi1 = this.Secondi;

            //valori del secondo orario (T2)
            int ore2 = t.Ore;
            int minuti2 = t.Minuti;
            int secondi2 = t.Secondi;

            //valori finali (della somma)
            int ore3;
            int minuti3;
            int secondi3;

            ore3 = ore1 + ore2;

            // Eseguo i controlli necessari

            if(ore3>=24)
            {
                ore3 = 0;
            }

            minuti3 = minuti1 + minuti2;
            if(minuti3>=60)
            {
                minuti3 = minuti3 - 60;
                ore3++;
            }

            secondi3 = secondi1 + secondi2;
            if(secondi3>=60)
            {
                secondi3 = secondi3-60;
                minuti3++;
                if (minuti3 >= 60)
                {
                    minuti3 = minuti3 - 60;
                    ore3++;
                }
            }

            return $"{ore3}:{minuti3}:{secondi3}";

        }
        public string SottraiTempo(Tempo t)
        {
            //valori del primo orario (T1)
            int ore1 = this.Ore;
            int minuti1 = this.Minuti;
            int secondi1 = this.Secondi;

            //valori del secondo orario (T2)
            int ore2 = t.Ore;
            int minuti2 = t.Minuti;
            int secondi2 = t.Secondi;

            //valori finali (della sottrazione)
            int ore3;
            int minuti3;
            int secondi3;

            ore3 = ore1 - ore2;

            // Eseguo i controlli necessari

            if (ore3 <= 0)
            {
                ore3 = 0;
            }

            minuti3 = minuti1 - minuti2;

            if (minuti3 < 0)
            {
                minuti3 = minuti3 + 60;
                ore3--;
            }

            secondi3 = secondi1 - secondi2;

            if (secondi3 < 0)
            {
                secondi3 = secondi3 + 60;
                minuti3--;
                if (minuti3 < 0)
                {
                    minuti3 = minuti3 + 60;
                    ore3--;
                }
            }


            return $"{ore3}:{minuti3}:{secondi3}";
        }

        public override string ToString()
        {
            if (_minuti < 10)
            {
                return $"{_ore}:0{_minuti}:{_secondi}";

            }
            else
            {
                return $"{_ore}:{_minuti}:{_secondi}";

            }
        }

    }
}
