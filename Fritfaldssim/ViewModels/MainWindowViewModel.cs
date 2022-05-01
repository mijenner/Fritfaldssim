using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Fritfaldssim.Models;

namespace Fritfaldssim.ViewModels
{
   public class MainWindowViewModel : ViewModelBase
   {
      public string Titel => "Fysiksimulator";

      public ObservableCollection<Tilstand>? SimResultsList { set;  get; }


      public MainWindowViewModel(ObservableCollection<Tilstand> sim)
      {
         SimResultsList = sim;
      }

      
   }
}
