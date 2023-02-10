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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Control oldParent;
        private Panel oldPanel;

        private void ShowExchangeForm()
        {
            var exchangeForm = new ExchangeForm();
            SetContent(exchangeForm.GetPanel());
            exchangeForm.ShowCurrencyData();
            exchangeForm.ShowFavouriteData();
            exchangeForm.SetStarterMark();
        }

        private void SetContent(Panel targetPanel)
        {
            if (oldPanel != null)
            {
                oldPanel.Parent = oldParent;
                if (oldParent is Form oldParentForm)
                {
                    oldParentForm.Close();
                    oldParentForm.Dispose();
                }
            }

            var targetParent = targetPanel.Parent;
            targetPanel.Parent = this.mainPanel;

            oldPanel = targetPanel;
            oldParent = targetParent;
        }

        private void aboutProgrammToolStripMI_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            SetContent(aboutForm.GetPanel());
        }

        private void exchangeToolStripMI_Click(object sender, EventArgs e)
        {
            ShowExchangeForm();
        }
    }
}
