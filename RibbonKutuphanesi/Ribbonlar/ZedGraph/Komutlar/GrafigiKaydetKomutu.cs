using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.ZedGraph.Komutlar
{
    public class GrafigiKaydetKomutu : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        GrafikKontrolcusu Grafik;

        public GrafigiKaydetKomutu(GrafikKontrolcusu grafik) => Grafik = grafik;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("Buraya giriyor");
            switch (parameter)
            {
                case "JPG":
                    Grafik.JPGKaydet();
                    break;
                case "TXT":
                    Grafik.TXTKaydet();
                    break;
            }
        }
    }
}