using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    private float RightPanelWidth => 100;
    

    public int RelativeSource => 200;


    public static void PercentageConverter()
    {
        
    }


}
