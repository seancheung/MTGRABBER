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

namespace MTGRABBER
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog logger = LogManager.GetLogger("Log4NetTest.LogTest");

        public Main()
        {
            InitializeComponent();
        }

        private void simpleButtonCheckAll_Click(object sender, EventArgs e)
        {
            //List<Card> cards = new List<Card>();
            //cards = FormatCard.GetCards("Theros", "THS");
            if (logger.IsDebugEnabled) logger.Debug("DEBUG");
            if (logger.IsInfoEnabled) logger.Info("INFO");
        }
    }
}