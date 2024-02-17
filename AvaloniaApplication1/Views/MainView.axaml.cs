using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using AvaloniaApplication1.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;
using System;
using System.Collections.Generic;

namespace AvaloniaApplication1.Views;

public partial class MainView : UserControl
{


    public List<PageManager> pages = new List<PageManager>();

    public MainView()
    {
        InitializeComponent();
        this.DataContextChanged += MainView_DataContextChanged;

        pages.Add(new PageManager(LaunchButton, LaunchWindow));
        pages.Add(new PageManager(ModsButton, ModsWindow));
        pages.Add(new PageManager(VersionsButton, VersionsWindow));
        pages.Add(new PageManager(ChangelogButton, ChangelogWindow));
        UpdateButtons(LaunchButton);

    }

    public void MenuButtonPressed(object? sender, RoutedEventArgs args)
    {
        UpdateButtons(sender as Button);
    }

    public void UpdateButtons(Button button)
    {
        foreach (var page in pages)
        {
            if(page.PageButton.Name == button.Name)
            {
                page.Page.IsVisible = true;
                page.PageButton.Background = new SolidColorBrush(Color.Parse("#FFFF550D"));
                page.PageButton.Foreground = new SolidColorBrush(Color.Parse("#FFFFFF"));
            }
            else
            {
                page.Page.IsVisible = false;
                page.PageButton.Background = new SolidColorBrush(Color.Parse("#FF383838"));
                page.PageButton.Foreground = new SolidColorBrush(Color.Parse("#FFFFBA7A"));
            }
        }
    }

    private void MainView_DataContextChanged(object sender, EventArgs e)
    {

    }
}


public class PageManager
{
    public PageManager(Button button,StackPanel page)
    {
        PageButton = button;
        Page = page;
    }
    public Button PageButton { get; private set; }
    public StackPanel Page { get; private set; }
}

