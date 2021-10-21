using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeTechTest
{
    public partial class BarCodeViewerForm : Form
    {
        public BarCodeViewerForm(string barCode)
        {
            InitializeComponent();
            this.barCode = barCode;
        }

        string barCode;

        private void BarCodeViewerForm_Load(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw bCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                drawerPB.Image = bCode.Draw(barCode, 60);
            }
            catch (Exception)
            { }
            
        }
    }
}
