using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.SeriPort.Komutlar
{
    public class ZamanıSifirlaKomutu : ICommand
    {
        SeriPortKontrolcusu Seriport;
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
        public ZamanıSifirlaKomutu(SeriPortKontrolcusu seriport)
        {
            Seriport = seriport;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            Seriport.StopWatch.Reset();
        }
    }
}