using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_face3
{
    class Program
    {

        static void Main(string[] args)

        {

            Musicfile m1 = new Musicfile("See You Again", "Wiz Knalifa ft. Charlie Puth", 20017, 210);
            Musicfile m2 = new Musicfile("Sorry", "Justin Bieber", 2015, 250);
            Musicfile m3 = new Musicfile("Uptown Funk", "Mark Ronson ft. Bruno Mars", 2014, 230);
            Musicfile m4 = new Musicfile("Blank Space", "Taylor Swift", 2016, 266);
            Musicfile m5 = new Musicfile("Shake It Off", "Taylor Swift", 2017, 258);
            Musicfile m6 = new Musicfile("Lean On", "Major Lazer & Dj Shake ft. Mo", 2018, 255);
            Musicfile m7 = new Musicfile("Hello", "Adeler", 2017, 245);
            Musicfile m8 = new Musicfile("Roa", "Kary Perry", 2019, 265);


            Radio r1 = new Radio("Radio Foorti 88.0fm");
            Radio r2 = new Radio("Radio Amar 89.40fm");
            Radio r3 = new Radio("Radio Express 91.0fm");
            Radio r4 = new Radio("Radio BD 94.5fm");







            Phone p1 = new Phone(2);
            p1.Switch(true);
            Console.WriteLine("0000000000000");



            p1.AddMusic(m1, m2, m3, m4, m5, m6, m7, m8);
            Console.WriteLine("0000000000000");
            Console.WriteLine("The Music files: ");
            p1.PrintMusic();
            Console.WriteLine("0000000000000");
            p1.play(true);
            Console.WriteLine("0000000000000");
            p1.playNext();
            Console.WriteLine("0000000000000");
            p1.playPrevious();
            Console.WriteLine("0000000000000");
            p1.setVolume(50);
            Console.WriteLine("0000000000000");





            p1.AddChannel(r1, r2, r3, r4);
            Console.WriteLine("0000000000000");
            p1.changeChannel(2);
            Console.WriteLine("0000000000000");
            p1.retune(55);
            Console.WriteLine("0000000000000");



        }

    }

}