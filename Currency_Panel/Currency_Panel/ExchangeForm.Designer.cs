namespace Currency_Panel
{
    partial class ExchangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.allCurrenciesTabPage = new System.Windows.Forms.TabPage();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.favouritesTabPage = new System.Windows.Forms.TabPage();
            this.favouritesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.allCurrenciesTabPage.SuspendLayout();
            this.favouritesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tabControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(418, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.allCurrenciesTabPage);
            this.tabControl1.Controls.Add(this.favouritesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // allCurrenciesTabPage
            // 
            this.allCurrenciesTabPage.Controls.Add(this.mainFlowLayoutPanel);
            this.allCurrenciesTabPage.Location = new System.Drawing.Point(4, 24);
            this.allCurrenciesTabPage.Name = "allCurrenciesTabPage";
            this.allCurrenciesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allCurrenciesTabPage.Size = new System.Drawing.Size(410, 422);
            this.allCurrenciesTabPage.TabIndex = 0;
            this.allCurrenciesTabPage.Text = "Все курсы";
            this.allCurrenciesTabPage.UseVisualStyleBackColor = true;
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.AutoScroll = true;
            this.mainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(404, 416);
            this.mainFlowLayoutPanel.TabIndex = 0;
            this.mainFlowLayoutPanel.WrapContents = false;
            // 
            // favouritesTabPage
            // 
            this.favouritesTabPage.Controls.Add(this.favouritesFlowLayoutPanel);
            this.favouritesTabPage.Location = new System.Drawing.Point(4, 24);
            this.favouritesTabPage.Name = "favouritesTabPage";
            this.favouritesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.favouritesTabPage.Size = new System.Drawing.Size(410, 422);
            this.favouritesTabPage.TabIndex = 1;
            this.favouritesTabPage.Text = "Избранные";
            this.favouritesTabPage.UseVisualStyleBackColor = true;
            // 
            // favouritesFlowLayoutPanel
            // 
            this.favouritesFlowLayoutPanel.AutoScroll = true;
            this.favouritesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favouritesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.favouritesFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.favouritesFlowLayoutPanel.Name = "favouritesFlowLayoutPanel";
            this.favouritesFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.favouritesFlowLayoutPanel.Size = new System.Drawing.Size(404, 416);
            this.favouritesFlowLayoutPanel.TabIndex = 1;
            this.favouritesFlowLayoutPanel.WrapContents = false;
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "ExchangeForm";
            this.Text = "ValutsForm";
            this.Load += new System.EventHandler(this.ExchangeForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.allCurrenciesTabPage.ResumeLayout(false);
            this.favouritesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private TabControl tabControl1;
        private TabPage allCurrenciesTabPage;
        private TabPage favouritesTabPage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel mainFlowLayoutPanel;
        private FlowLayoutPanel favouritesFlowLayoutPanel;
    }
}