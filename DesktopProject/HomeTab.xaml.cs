﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopProject
{
    /// <summary>
    /// Interaction logic for HomeTabxaml.xaml
    /// </summary>
    public partial class HomeTab : UserControl
    {
        private static HomeTab instance;

        public static HomeTab Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HomeTab();
                }
                return instance;
            }
        }
        public HomeTab()
        {
            InitializeComponent();
        }
    }
}
