using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Globalization;

namespace Service_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            CurrentDataPicker.SelectedDate = DateTime.Now;
            txtbx_result.Text = "الرجاء تحديد تاريخ التعيين !";
        }

        private void EmploymentDataPicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayServiceDuration();
        }

        private void CurrentDataPicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayServiceDuration();
        }

        private void DisplayServiceDuration()
        {
            if (EmploymentDataPicker.SelectedDate.HasValue && CurrentDataPicker.SelectedDate.HasValue)
            {
                txtbx_result.Text ="مدة الخدمة = " + CalculateService(CalculateDays((DateTime)EmploymentDataPicker.SelectedDate, (DateTime)CurrentDataPicker.SelectedDate)).ToString();
            }
        }

        private TimeSpan CalculateDays(DateTime date1, DateTime date2)
        {
            TimeSpan time = date2 - date1;
            return time;
        }
        private ServiceDuration CalculateService(TimeSpan span)
        {
            ServiceDuration duration = new Service_Calculator.ServiceDuration();
            duration.Years = (int)(span.Days / 365.25);
            duration.Months = (int)((span.Days - duration.Years * 365.25) / 30);
            duration.Days = (int)(span.Days - duration.Years * 365.25 - duration.Months*30);
            return duration;
        }
        
        
    }
}
