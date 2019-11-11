using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.SeriPort.Komutlar
{
    public class ArabellekTemizleKomutu : ICommand
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

        SeriPortKontrolcusu SeriportKontrolcu;

        public ArabellekTemizleKomutu(SeriPortKontrolcusu seriportkontrolcusu) => SeriportKontrolcu = seriportkontrolcusu;
        public bool CanExecute(object parameter)
        {
            return SeriportKontrolcu.SeriPort.IsOpen;
        }

        public void Execute(object parameter)
        {
            SeriportKontrolcu.PortArabellekTemizle();
        }
    }
}