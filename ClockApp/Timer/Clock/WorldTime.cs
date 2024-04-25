using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer.Clock
{
    public partial class WorldTime : UserControl
    {
        public WorldTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hwTime = DateTime.UtcNow;
            //label4.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(hwTime, "Korea Standard Time").ToString();   // 한국
            //label3.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(hwTime, "US Eastern Standard Time").ToString();  // 뉴욕

        }
    }
}
