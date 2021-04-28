using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_face3
{
    class Musicfile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSecond;

        public Musicfile()
        {

        }
        public Musicfile(string title,string artist,int yearOfRelease,int durationInsecounds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSecond = durationInSecond;



        }
        private Phone phone;
        public Phone Ph
        {
            get { return phone; }
            set { phone = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Title:" + title);
            Console.WriteLine("Artist:" + artist);
            Console.WriteLine("Year Of Release:" + yearOfRelease);
            Console.WriteLine("Duation In Secound:" + durationInSecond);

        }
    }
}
