using Avalonia.Controls;
using ScottPlot.Avalonia;

namespace Fritfaldssim.Views
{
   public partial class MainWindow : Window
   {

      public MainWindow()
      {
         InitializeComponent();
         AvaPlot avaPlot1 = this.Find<AvaPlot>("AvaPlot1");
         avaPlot1.Plot.AddScatter();  // can't get data into this. 
      }
   }
}
