﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frame.Interface;
using Frame.Class;

namespace Frame.View
{
    public partial class SettingView : MessageUserControl
    {
        public SettingView()
        {
            InitializeComponent();
        }
        public void OnMsg2(Msg2 msg)
        {
            MessageBox.Show("SettingView"+msg.dt.GetDateTimeFormats()[10]);
        }
    }
}
