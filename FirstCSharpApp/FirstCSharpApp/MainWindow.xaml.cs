using System;
using System.Collections.Generic;
using System.IO;
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

namespace FirstCSharpApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Open data file
            StreamReader myDataStream = File.OpenText("FirstCSharpApp.csv");

            // Read lines
            String line = myDataStream.ReadLine();
            // Split the fields (Cells, Columns)
            string[] fields = line.Split(",".ToCharArray());
            // Populate Textboxes
            row1col1.Text = fields[0];
            row1col2.Text = fields[1];
            row1col3.Text = fields[2];

            // Read lines
            line = myDataStream.ReadLine();
            // Split the fields (Cells, Columns)
            fields = line.Split(",".ToCharArray());
            // Populate Textboxes
            row2col1.Text = fields[0];
            row2col2.Text = fields[1];
            row2col3.Text = fields[2];


            //Read Lines
            line = myDataStream.ReadLine();
            // Split the fields (Cells, Columns)
            fields = line.Split(",".ToCharArray());
            // populate textboxes
            row3col1.Text = fields[0];
            row3col2.Text = fields[1];
            row3col3.Text = fields[2];
           

            //Read lines
            line = myDataStream.ReadLine();
            // Split the fields (Cells, Columns)
            fields = line.Split(",".ToCharArray());
            // populate Textboxes
            row4col1.Text = fields[0];
            row4col2.Text = fields[1];
            row4col3.Text = fields[2];



            row1col1.IsEnabled = false;
            row1col2.IsEnabled = false;
            row1col3.IsEnabled = false;
            row2col1.IsEnabled = false;
            row2col2.IsEnabled = false;
            row2col3.IsEnabled = false;
            row3col1.IsEnabled = false;
            row3col2.IsEnabled = false;
            row3col3.IsEnabled = false;
            row4col1.IsEnabled = false;
            row4col2.IsEnabled = false;
            row4col3.IsEnabled = false;


        }
    }
}
