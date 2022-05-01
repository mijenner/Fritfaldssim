using Avalonia.Controls;
using ScottPlot.Avalonia;

namespace Fritfaldssim.Views
{
   public partial class MainWindow : Window
   {
      double[] timeA; 

      public MainWindow()
      {
         InitializeComponent();
         
         // timeA = new double[numElements];
         AvaPlot avaPlot1 = this.Find<AvaPlot>("AvaPlot1");

         // avaPlot1.Plot.AddScatter(time, speed);  
      }

   }
}
