using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RibbonKutuphanesi.Formlar;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.ZedGraph.Komutlar
{
    public class Form_GrafikAcKomutu : ICommand
    {
        GrafikKontrolcusu Kontrolcu;
        Form_Grafik form_grafik;
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
        public Form_GrafikAcKomutu(GrafikKontrolcusu kontrolcu)
        {
            Kontrolcu = kontrolcu;
            form_grafik = new Form_Grafik(Kontrolcu);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            form_grafik.ShowDialog();
        }
    }
}