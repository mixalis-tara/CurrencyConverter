using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Services
{
    internal class ButtonService
    {
        private MainWindow _mainWindow;

        // Pass MainWindow instance to the constructor
        public ButtonService(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }
        //ClearControls used for clear all controls value
        public void ClearControls()
        {
            _mainWindow.txtCurrency.Text = string.Empty;
            if (_mainWindow.cmbFromCurrency.Items.Count > 0)
                _mainWindow.cmbFromCurrency.SelectedIndex = 0;
            if (_mainWindow.cmbToCurrency.Items.Count > 0)
                _mainWindow.cmbToCurrency.SelectedIndex = 0;
            _mainWindow.lblCurrency.Content = "";
            _mainWindow.txtCurrency.Focus();
        }
    }
}
