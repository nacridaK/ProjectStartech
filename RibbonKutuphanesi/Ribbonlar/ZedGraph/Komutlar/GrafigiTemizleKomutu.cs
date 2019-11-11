using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.ZedGraph.Komutlar
{
    public class GrafigiTemizleKomutu : ICommand
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

        public GrafigiTemizleKomutu(GrafikKontrolcusu grafik) => Grafik = grafik;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            Grafik.Temizle();
        }
    }
}