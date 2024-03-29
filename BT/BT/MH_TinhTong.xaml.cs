﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MH_TinhTong : ContentPage
    {
        public MH_TinhTong()
        {
            InitializeComponent();
        }
        private void cmdtinhtong_Clicked(object sender, EventArgs e)
        {
            double so1, so2, tong;
            so1 = Double.Parse(txtsoa.Text);
            so2 = Double.Parse(txtsob.Text);
            tong = so1 + so2;
            txttong.Text = tong.ToString();
        }
        private void cmdvetrangchu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}