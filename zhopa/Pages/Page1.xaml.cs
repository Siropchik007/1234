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
using ClassLibrary1;


namespace zhopa.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private ClassRep _cp;
        private ClassMainRep _cmp;

        public Page1()
        {
            InitializeComponent();
            _cp = new ClassRep();
            _cmp = new ClassMainRep(_cp);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Update();*/
        }
        
        /*
        public void Update()
        {
            Class1.ItemSource = _cpm.GetAllList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selected = (Class1)_Class1.SelectedItem; 
        }*/
    }
}
