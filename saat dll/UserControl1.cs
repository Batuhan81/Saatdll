using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saat_dll
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        int saniye;
        int dakika;
        int saat;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if(saniye%60==0 )
            {
                dakika++;
                saniye = 0;
            }
            if (dakika % 60 == 0)
            {
                dakika++;
                dakika = 0;
            }
            if (saat % 24 == 0)
            {
                saat++;
                saat = 0;
            }
            label1.Text=saat.ToString("00:")+dakika.ToString("00:")+saniye.ToString("00");
        }
        [Browsable(true), Description("Label üzerinde  dijital saat yapımı"), Category("Odaklama")]
        public override string Text
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
    }
}
