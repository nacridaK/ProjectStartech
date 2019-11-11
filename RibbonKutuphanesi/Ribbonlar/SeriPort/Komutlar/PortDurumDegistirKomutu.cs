using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.SeriPort.Komutlar
{
    public class PortDurumDegistirKomutu : ICommand
    {
        SeriPortKontrolcusu SeriportKontrolcusu;
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
        public PortDurumDegistirKomutu(SeriPortKontrolcusu seriport) => SeriportKontrolcusu = seriport;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            if (SeriportKontrolcusu.SeriPort.IsOpen)
                SeriportKontrolcusu.PortKapat();
            else
                SeriportKontrolcusu.PortAc();
        }
    }
}