using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RibbonKutuphanesi.Formlar;
using RibbonKutuphanesi.Kontrolculer;

namespace RibbonKutuphanesi.Ribbonlar.SeriPort.Komutlar
{
    public class Form_SeriportAcKomutu : ICommand
    {
        SeriPortKontrolcusu Seriport;
        Form_Seriport form_seriport;
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
        public Form_SeriportAcKomutu(SeriPortKontrolcusu seriport)
        {
            Seriport = seriport;
            form_seriport = new Form_Seriport(Seriport);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            form_seriport.ShowDialog();
        }
    }
}