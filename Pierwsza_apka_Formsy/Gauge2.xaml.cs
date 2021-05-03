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
    /// Logika interakcji dla klasy Gauge2.xaml
    /// </summary>
    public partial class Gauge2 : UserControl
    {
        
        public double pointervalue_2;
        public double gauge2_value;

        public Gauge2()
        {
            InitializeComponent();
        }

        public void ChangeValue()
        {
            RotateTransform rotate = new RotateTransform(pointervalue_2);
            ArrowPointer.RenderTransform = rotate;
            Kat_napis.Text = gauge2_value.ToString();
        }
    }
}

