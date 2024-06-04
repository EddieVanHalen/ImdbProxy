using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace ImdbProxy;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static ServiceCollection Collection { get; set; } = null!;
    public static ServiceProvider Provider { get; set; } = null!;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        Collection = new ServiceCollection();

        Collection.AddSingleton<>();
    }
}