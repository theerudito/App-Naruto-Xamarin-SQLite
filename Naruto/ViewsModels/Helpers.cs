﻿using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Naruto.ViewsModels
{
    public class Helpers : BaseViewModel
    {
        #region VARIABLES

        private string _Text;

        #endregion VARIABLES

        #region CONSTRUCTOR

        public Helpers()
        {
        }

        #endregion CONSTRUCTOR

        #region OBJETOS

        public string Text
        {
            get { return _Text; }
            set { SetValue(ref _Text, value); }
        }

        #endregion OBJETOS

        #region METODOS ASYNC

        public async Task MetodoAsincrono()
        {
            await Task.Delay(1000);
            Text = "Hola Mundo";
        }

        #endregion METODOS ASYNC

        #region METODOS SIMPLE

        public void MetodoSimple()
        {
            Text = "Hola Mundo";
        }

        #endregion METODOS SIMPLE

        #region COMANDOS

        public ICommand AlertaAsincrona => new Command(async () => await MetodoAsincrono());
        public ICommand AlertaSimple => new Command(() => MetodoSimple());

        #endregion COMANDOS
    }
}