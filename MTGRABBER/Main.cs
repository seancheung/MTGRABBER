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

namespace MTGRABBER
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void simpleButtonCheckAll_Click(object sender, EventArgs e)
        {
            List<Card> cards = new List<Card>();
            cards = FormatID.GetIDList("Theros", "THS");
            cards = FormatForeignID.GetIDList(cards, LANGUAGE.Chinese_Simplified);
            string s = string.Empty;
        }
    }
}