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
    public partial class SpecificCurrencyPanel : UserControl
    {
        private string _idCurrency = "";
        private float _currentCurrencyValue = 0;
        private string _currencyName = "[Название валюты]";
        private float _currencyChange = 0;
        private float _currencyChangePerc = 0;
        private int _currencyChangeStatun = 0;
        private bool _favoriteChecked = false;


        public SpecificCurrencyPanel()
        {
            InitializeComponent();
        }

        public SpecificCurrencyPanel(string idCurrency, float currentCurrencyValue, float prevCurrencyValue, string currencyName, bool favoriteChecked)
        {
            InitializeComponent();
            SetCurrencyData(idCurrency, currentCurrencyValue, prevCurrencyValue, currencyName, favoriteChecked);
        }

        public void SetCurrencyData(string idCurrency, float currentCurrencyValue, float prevCurrencyValue, string currencyName, bool favoriteChecked)
        {
            _idCurrency = idCurrency;
            _currentCurrencyValue = currentCurrencyValue;
            _currencyName = currencyName;

            _currencyChange = currentCurrencyValue - prevCurrencyValue;
            _currencyChangePerc = _currencyChange / (currentCurrencyValue / 100);
            if (_currencyChange > 0)
                _currencyChangeStatun = 1;
            else if (_currencyChange < 0)
                _currencyChangeStatun = 2;
            else
                _currencyChangeStatun = 0;
            _favoriteChecked = favoriteChecked;

            ShowCurrencyData();
        }

        private void ShowCurrencyData()
        {
            currencyValueLabel.Text = _currentCurrencyValue.ToString();
            сcurrencyNameLabel.Text = _currencyName;
            currencyChangeLabel.Text = _currencyChange.ToString();
            currencyChangePercLabel.Text = _currencyChangePerc.ToString() + '%';

            switch (_currencyChangeStatun)
            {
                case 0:
                    currencyChangePictureBox.Image = Currency_Panel.Properties.Resources.Raising_image;
                    break;
                case 1:
                    currencyChangePictureBox.Image = Currency_Panel.Properties.Resources.Raising_image;
                    break;
                case 2:
                    currencyChangePictureBox.Image = Currency_Panel.Properties.Resources.Decline_image;
                    break;
                default:
                    currencyChangePictureBox.Image = Currency_Panel.Properties.Resources.Raising_image;
                    break;      
            }

            if (_favoriteChecked)
                favoriteCheckBox.BackgroundImage = Currency_Panel.Properties.Resources.favorite_star;
            else
                favoriteCheckBox.BackgroundImage = Currency_Panel.Properties.Resources.unfavorite_star;
        }

        private void favoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.FavoritesCurrency favoritesCurrency = new DataBase.FavoritesCurrency();

            if (_favoriteChecked)
            {
                _favoriteChecked = false;
                favoriteCheckBox.BackgroundImage = Currency_Panel.Properties.Resources.unfavorite_star;
                favoritesCurrency.DeleteFavoutire(_idCurrency);
            }
            else
            {
                _favoriteChecked = true;
                favoriteCheckBox.BackgroundImage = Currency_Panel.Properties.Resources.favorite_star;
                favoritesCurrency.AddFavourite(_idCurrency);
            }
        }
    }
}
