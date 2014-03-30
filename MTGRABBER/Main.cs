using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FORMATTER;
using MODEL;
using System.Runtime.InteropServices;
using log4net;
using System.Diagnostics;
using System.Threading;
using CONVERTER;

namespace MTGRABBER
{
    public partial class Main : XtraForm
    {
        private static readonly ILog logger = LogManager.GetLogger("App.Debugger");
        private List<Card> cards;

        public Main()
        {
            InitializeComponent();
            cards = new List<Card>();
            
        }

        private void simpleButtonCheckAll_Click(object sender, EventArgs e)
        {
            MODEL.Consoler.LoadConsole();

            new Thread(new ThreadStart(GetCards)).Start();

            //if (logger.IsDebugEnabled) logger.Debug("DEBUG");
            //if (logger.IsInfoEnabled) logger.Info("INFO");

        }

        public void GetCards()
        {
            cards = FormatCard.GetCards("Theros", "THS");
            SaveCards();
        }

        public void SaveCards()
        {
            if (cards.Count > 0)
            {
                new ExportData().Export(cards, "DATA.xml");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Environment.Exit(0);
        }
    }
}