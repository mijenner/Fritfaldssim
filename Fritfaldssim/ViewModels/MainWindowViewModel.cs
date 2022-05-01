using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Fritfaldssim.Services;

namespace Fritfaldssim.ViewModels
{
   public class MainWindowViewModel : ViewModelBase
   {
      public Simulate simulate { get; }
      public string Titel { get; } 
      public ObservableCollection<double> time { get; }
      public ObservableCollection<double> position { get; }
      public ObservableCollection<double> speed { get; }
      public int NumElements { get;  } 

      public MainWindowViewModel(Simulate sim)
      {
         Titel = "Fysiksimulator"; 
         this.simulate = sim;
         this.time = sim.time;
         this.position = sim.position;
         this.speed = sim.speed;
         this.NumElements = sim.speed.Count;
      }
   }
}
