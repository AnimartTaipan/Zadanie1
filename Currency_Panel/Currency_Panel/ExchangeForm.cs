using CentralBankServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Panel
{
    public partial class ExchangeForm : Form
    {
        public ExchangeForm()
        {
            InitializeComponent();
        }

        public Panel GetPanel() => mainPanel;

        private void ExchangeForm_Load(object sender, EventArgs e)
        {
            ShowCurrencyData();
            ShowFavouriteData();
        }

        public void ShowCurrencyData()
        {
            using var client = new CentralBankServiceReference.DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            var actual_currencys = client.GetCursOnDateXML(DateTime.Today);
            var yesterday_currencys = client.GetCursOnDateXML(DateTime.Today.AddDays(-7));

            int length = actual_currencys.ChildNodes.Count;
            SpecificCurrencyPanel[] CurrencyPanels = new SpecificCurrencyPanel[length];
            DataBase.FavoritesCurrency favoritesCurrency = new DataBase.FavoritesCurrency();

            for (int i = 0; i < length; i++)
            {
                var actual_currency = actual_currencys.ChildNodes[i];
                var yesterday_currency = yesterday_currencys.ChildNodes[i];

                string idCurrency = actual_currency["Vcode"].InnerText.Trim();
                float currentCurrencyValue = float.Parse(actual_currency["Vcurs"].InnerText.Trim().Replace('.', ','));
                float prevCurrencyValue = float.Parse(yesterday_currency["Vcurs"].InnerText.Trim().Replace('.', ','));
                var currencyName = actual_currency["Vname"].InnerText.Trim();
                bool favoriteChecked = favoritesCurrency.IsFavoutire(idCurrency);

                CurrencyPanels[i] = new SpecificCurrencyPanel(idCurrency, currentCurrencyValue, prevCurrencyValue, currencyName, favoriteChecked);
                mainFlowLayoutPanel.Controls.Add(CurrencyPanels[i]);
            }
        }

        public void ShowFavouriteData()
        {
            using var client = new CentralBankServiceReference.DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            var actual_currencys = client.GetCursOnDateXML(DateTime.Today);
            var yesterday_currencys = client.GetCursOnDateXML(DateTime.Today.AddDays(-7));
            DataBase.FavoritesCurrency favoritesCurrency = new DataBase.FavoritesCurrency();
            var favoritesCurrencysId = favoritesCurrency.GetFavourites();

            var CurrencyPanels = new List<SpecificCurrencyPanel>();

            foreach (var favourite in favoritesCurrencysId)
            {
                string idCurrency = favourite.FavouriteId;
                var actual_currency = actual_currencys.SelectSingleNode($"descendant::ValuteCursOnDate[Vcode='{idCurrency}']");
                var yesterday_currency = yesterday_currencys.SelectSingleNode($"descendant::ValuteCursOnDate[Vcode='{idCurrency}']");

                float currentCurrencyValue = float.Parse(actual_currency["Vcurs"].InnerText.Trim().Replace('.', ','));
                float prevCurrencyValue = float.Parse(yesterday_currency["Vcurs"].InnerText.Trim().Replace('.', ','));
                var currencyName = actual_currency["Vname"].InnerText.Trim();
                bool favoriteChecked = favoritesCurrency.IsFavoutire(idCurrency);

                CurrencyPanels.Add(new SpecificCurrencyPanel(idCurrency, currentCurrencyValue, prevCurrencyValue, currencyName, favoriteChecked));
                favouritesFlowLayoutPanel.Controls.Add(CurrencyPanels.Last());
            }
        }

        public void SetStarterMark()
        {
            DataBase.FavoritesCurrency favoritesCurrency = new DataBase.FavoritesCurrency();
            var favoritesCurrencysId = favoritesCurrency.GetFavourites();
            if (favoritesCurrencysId == null)
                return;

            tabControl1.SelectTab("favouritesTabPage");
        }
    }
}
