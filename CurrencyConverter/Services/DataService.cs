using CurrencyConverter.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CurrencyConverter.Services
{
    public class DataService
    {

        private Root _val = new Root();
        private MainWindow _mainWindow;

        // Pass MainWindow instance to the constructor
        public DataService(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }
        public async Task GetValueAsync()
        {
            _val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=aa0a368a03504ffab02db52b9e255b10");
            BindCurrency();
        }

        public static async Task<Root> GetData<T>(string url)
        {
            var myRoot = new Root();
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(1);
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var ResponseString = await response.Content.ReadAsStringAsync();
                        var ResponseObject = JsonConvert.DeserializeObject<Root>(ResponseString);

                        //MessageBox.Show("Rates: " + ResponseString, "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                        return ResponseObject;
                    }
                    return myRoot;
                }
            }
            catch
            {
                return myRoot;
            }
        }
        public void BindCurrency()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Text");
            dt.Columns.Add("Value");

            dt.Rows.Add("--SELECT--", 0);
            dt.Rows.Add("INR", _val.rates.INR);
            dt.Rows.Add("USD", _val.rates.USD);
            dt.Rows.Add("NZD", _val.rates.NZD);
            dt.Rows.Add("JPY", _val.rates.JPY);
            dt.Rows.Add("EUR", _val.rates.EUR);
            dt.Rows.Add("CAD", _val.rates.CAD);
            dt.Rows.Add("ISK", _val.rates.ISK);
            dt.Rows.Add("PHP", _val.rates.PHP);
            dt.Rows.Add("DKK", _val.rates.DKK);
            dt.Rows.Add("CZK", _val.rates.CZK);

            _mainWindow.cmbFromCurrency.ItemsSource = dt.DefaultView;
            _mainWindow.cmbFromCurrency.DisplayMemberPath = "Text";
            _mainWindow.cmbFromCurrency.SelectedValuePath = "Value";

            _mainWindow.cmbFromCurrency.SelectedIndex = 0;

            _mainWindow.cmbToCurrency.ItemsSource = dt.DefaultView;
            _mainWindow.cmbToCurrency.DisplayMemberPath = "Text";
            _mainWindow.cmbToCurrency.SelectedValuePath = "Value";
            _mainWindow.cmbToCurrency.SelectedIndex = 0;

        }
    }
}
