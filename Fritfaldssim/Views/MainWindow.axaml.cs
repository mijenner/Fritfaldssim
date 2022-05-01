using Avalonia.Controls;
using Fritfaldssim.Models;
using Fritfaldssim.ViewModels;
using ScottPlot.Avalonia;
using System.Collections.ObjectModel;

namespace Fritfaldssim.Views
{
   public partial class MainWindow : Window
   {
      public ObservableCollection<Tilstand> SimResult { get; set; }

      public MainWindow()
      {
         InitializeComponent();
         AvaPlot avaPlot1 = this.Find<AvaPlot>("AvaPlot1");

         // avaPlot1.Plot.AddScatter();  // can't get data into this. 
      }

      public void OnClickButton()
      {

      }

   }
}
