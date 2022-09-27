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
    /// Interaction logic for PrintBarcode.xaml
    /// </summary>
    public partial class PrintBarcode : Window
    {


        public PrintBarcode()
        {
            InitializeComponent();
            loadInitialDetails();
        }

        private void loadInitialDetails()
        {
            loadProducts();
        }

        private void loadProducts()
        {
            try
            {
                using (ChannelFactory<IProduct> productProxy = new ChannelFactory<ServerServiceInterface.IProduct>("ProductEndpoint"))
                {
                    productProxy.Open();
                    IProduct productService = productProxy.CreateChannel();
                    List<CProduct> products = productService.ReadAllProducts();
                    mComboProduct.ItemsSource = products;
                    mComboProduct.DisplayMemberPath = "Product";
                    mComboProduct.SelectedValuePath = "ProductCode";
                }
            }
            catch
            {

            }
        }

        private void showDataFromDatabase()
        {
            try
            {
                string productCode = "";
                if (mComboProduct.SelectedItem != null && (mComboProduct.SelectedItem as CProduct).Product.Equals(mComboProduct.Text))
                {
                    productCode = mComboProduct.SelectedValue.ToString();
                }
                string product = mComboProduct.Text.Trim();

                using (ChannelFactory<IBarcode> barcodeProxy = new ChannelFactory<ServerServiceInterface.IBarcode>("BarcodeEndpoint"))
                {
                    barcodeProxy.Open();
                    IBarcode barcodeService = barcodeProxy.CreateChannel();                
                    mDataGrid.ItemsSource = barcodeService.FindBarcodesBetweenDates(mDTPStartDate.SelectedDate.Value, mDTPEndDate.SelectedDate.Value, productCode);
                }
            }
            catch (Exception e)
            {
               
            }

            setTotalBarcodes();
        }

        private void setTotalBarcodes()
        {
            decimal gTotal = 0;
            try
            {

                gTotal = ((List<CBarcodeDetails>)mDataGrid.ItemsSource).Where(x=> (x.Select==true)).Sum(x => (x.Quantity));

            }
            catch
            {

            }
            try {
                mLabelTotalNo.Content = gTotal.ToString("N0");
            }
            catch { }
        }


        private void mDTPStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            showDataFromDatabase();
        }

        private void mDTPEndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            showDataFromDatabase();
        }

        private void mComboProduct_SelectionChanged(object sender, RoutedEventArgs e)
        {
            showDataFromDatabase();
        }

        private void mButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //Check All Rows
            try {
                ((List<CBarcodeDetails>)mDataGrid.ItemsSource).ForEach(x => x.Select = true);
                mDataGrid.Items.Refresh();
            }
            catch { }

            setTotalBarcodes();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            //Uncheck All Rows
            try
            {
                ((List<CBarcodeDetails>)mDataGrid.ItemsSource).ForEach(x => x.Select = false);
                mDataGrid.Items.Refresh();
            }
            catch { }

            setTotalBarcodes();
        }

        private void SubCheckBox_Checked(object sender, RoutedEventArgs e)
        {            
            setTotalBarcodes();        
        }

        private void SubCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {            
            setTotalBarcodes();
        }
    }
}
