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

namespace Pierwsza_apka_Formsy
{
    /// <summary>
    /// Logika interakcji dla klasy Gauge3.xaml
    /// </summary>
    public partial class Gauge3 : UserControl
    {
        public double pointervalue_3;
        public double gauge3_value;
        public Gauge3()
        {
            InitializeComponent();
        }

        public void ChangeValue()
        {
            RotateTransform rotate = new RotateTransform(pointervalue_3);
            ArrowPointer.RenderTransform = rotate;
            Temperatura_napis.Text = gauge3_value.ToString();
        }
    }
}
