using System;
using System.Linq;
using Avalonia.Controls;
using Fritfaldssim.ViewModels;
using ScottPlot.Avalonia;

namespace Fritfaldssim.Views
{
   public partial class MainWindow : Window
   {
      

      public MainWindow()
      {
         InitializeComponent();
      }

      protected override void OnDataContextChanged(EventArgs e)
      {
         base.OnDataContextChanged(e);

         if (DataContext is MainWindowViewModel vm)
         {
            AvaPlot avaPlot1 = this.Find<AvaPlot>("AvaPlot1");

            avaPlot1.Plot.AddScatter(vm.time.ToArray(), vm.speed.ToArray());  
         }
         
      }
   }
}
