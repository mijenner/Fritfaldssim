using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Fritfaldssim.Models;
using Fritfaldssim.Services;

namespace Fritfaldssim.ViewModels
{
   public class MainWindowViewModel : ViewModelBase
   {
      public Simulate simulate { get; }
      public string Titel { get; } 
      public ObservableCollection<Tilstand> SimResultsList { get; }

      public MainWindowViewModel(Simulate sim)
      {
         Titel = "Fysiksimulator"; 
         simulate = sim;
         SimResultsList = simulate.SimResult;
      }
   }
}
