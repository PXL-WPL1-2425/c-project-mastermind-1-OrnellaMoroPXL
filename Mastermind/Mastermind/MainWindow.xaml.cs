using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GeneratedSolution();
        }

        

        private void GeneratedSolution()
        {
            Random randomColorGenerator = new Random();
            string solution = "";

            for (int i = 0; i < 4; i++)
            {
                int randomColorIndex = randomColorGenerator.Next(6);

                switch (randomColorIndex)
                {
                    case 0:
                        solution += "Red";
                    break;

                    case 1:
                        solution += "Orange";
                    break;

                    case 2:
                        solution += "Yellow";
                    break;

                    case 3:
                        solution += "Green";
                    break;

                    case 4:
                        solution += "Blue";
                    break;

                    case 5:
                        solution += "White";
                    break;

                }
                if (i < 3)
                {
                    solution += ", ";
                }
                

                

            }

            this.Title = solution;



        }
        private void ValidateAnswers_Click(object sender, RoutedEventArgs e)
        {

        }







    }
}
