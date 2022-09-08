using System;
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

namespace Tang_algorithm_cul1
{
    /// <summary>
    /// dataview2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class dataview2 : UserControl
    {
        public dataview2()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void maingridcon_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
