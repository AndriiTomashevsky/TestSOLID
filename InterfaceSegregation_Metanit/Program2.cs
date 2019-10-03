using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Metanit2
{
    interface IPhone
    {
        void Call();
        void TakePhoto();
        void MakeVideo();
        void BrowseInternet();
    }

    class Phone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Звоним");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
        }

        public void MakeVideo()
        {
            Console.WriteLine("Снимаем видео");
        }

        public void BrowseInternet()
        {
            Console.WriteLine("Серфим в интернете");
        }
    }

    class Photograph
    {
        public void TakePhoto(Phone phone)
        {
            phone.TakePhoto();
        }
    }

    class Camera : IPhone
    {
        public void Call() { }

        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
        }

        public void MakeVideo() { }
        public void BrowseInternet() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Photograph photograph = new Photograph();
            Phone lumia950 = new Phone();

            photograph.TakePhoto(lumia950);
        }
    }
}
