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
    /// Logika interakcji dla klasy Gauge1.xaml
    /// </summary>
    public partial class Gauge1 : UserControl
    {
        public double pointervalue_1;
        public double gauge1_value;

        public Gauge1()
        {
            InitializeComponent();
        }

        public void ChangeValue()
        {
            RotateTransform rotate = new RotateTransform(pointervalue_1);
            ArrowPointer.RenderTransform = rotate;
            Obroty_napis.Text = gauge1_value.ToString();  
        }
    }
}
