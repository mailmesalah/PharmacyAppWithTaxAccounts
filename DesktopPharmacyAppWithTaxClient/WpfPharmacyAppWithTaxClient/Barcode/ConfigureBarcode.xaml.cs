using ServerServiceInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using WpfClientApp.General;

namespace WpfClientApp.Barcode
{
    /// <summary>
    /// Interaction logic for ConfigureBarcode.xaml
    /// </summary>
    public partial class ConfigureBarcode : Window
    {

        private float mStartX=5;
        private float mStartY = 5;
        private float mBWidth = 768;
        private float mBHeight = 1104;
        private float mBHGap = 10;
        private float mBVGap = 5;

        public ConfigureBarcode()
        {
            InitializeComponent();
            loadInitialDetails();
        }

        private void loadInitialDetails()
        {
            mCanvasBarcodesPreview.Width = mBWidth;
            mCanvasBarcodesPreview.Height = mBHeight;
            //Set current values to Textboxes
            mTextBoxWidth.Text = mBWidth.ToString();
            mTextBoxHeight.Text = mBHeight.ToString();
            mTextBoxStartAtX.Text = mStartX.ToString();
            mTextBoxHBarcodeGap.Text = mBHGap.ToString();
            mTextBoxVBarcodeGap.Text = mBVGap.ToString();

        }
        
        private void mButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mTextBoxWidth_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
