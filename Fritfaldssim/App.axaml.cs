using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Fritfaldssim.Services;
using Fritfaldssim.ViewModels;
using Fritfaldssim.Views;

namespace Fritfaldssim
{
   public partial class App : Application
   {
      Simulate? sim; 

      public override void Initialize()
      {
         AvaloniaXamlLoader.Load(this);
      }

      public override void OnFrameworkInitializationCompleted()
      {
         if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
         {
            sim = new Simulate(); 

            desktop.MainWindow = new MainWindow
            {
               DataContext = new MainWindowViewModel(sim),
            };
         }

         base.OnFrameworkInitializationCompleted();
      }
   }
}
