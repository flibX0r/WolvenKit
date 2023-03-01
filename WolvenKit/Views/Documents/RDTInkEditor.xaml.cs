﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTInkEditor.xaml
    /// </summary>
    public partial class RDTInkEditor : ReactiveUserControl<RDTInkEditorViewModel>
    {
        public RDTInkEditor()
        {
            InitializeComponent();
        }
    }
}
