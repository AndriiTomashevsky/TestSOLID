using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Metanit2
{
    interface IPhoto
    {
        void TakePhoto();
    }

    interface IPhone : IPhoto
    {
        void Call();
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

    class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
        }
    }

    class Photograph
    {
        public void TakePhoto(IPhoto photoMaker)
        {
            photoMaker.TakePhoto();
        }
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
