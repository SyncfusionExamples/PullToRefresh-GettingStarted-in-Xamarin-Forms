# PullToRefresh-GettingStarted-in-Xamarin-Forms

## About the sample
This repository contains the sample to help you get started with the Syncfusion's PulToRefresh control for Xamarin.Forms

Create a new BlankApp (Xamarin.Forms.NET Standard) application in Xamarin Studio or Visual Studio for Xamarin.Forms.
Import the SfPullToRefresh control namespace Syncfusion.SfPullToRefresh.XForms and set the SfPullToRefresh control to the ContentPage.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage" 
             xmlns:syncfusion="clr-namespace:Syncfusion.SfPullToRefresh.XForms;assembly=Syncfusion.SfPullToRefresh.XForms">
    <syncfusion:SfPullToRefresh x:Name="pullToRefresh" />
</ContentPage>

```
```c#
using Syncfusion.SfPullToRefresh.XForms;
using Xamarin.Forms;

namespace GettingStarted
{
    public class App : Application
    {
        StackLayout layout;
        Label label;
        public App()
        {
            layout = new StackLayout();
            label = new Label();
            label.Text = "PullableContent";
            label.BackgroundColor = Color.SkyBlue;
            layout.Children.Add(label);
            pullToRefresh.Content = layout;
            pullToRefresh.Refreshing += PullToRefresh_Refreshing;
            MainPage = new ContentPage { Content = pullToRefresh};
        }

        private async void PullToRefresh_Refreshing(object sender, EventArgs args)
        {
            pullToRefresh.IsRefreshing = true;
            await Task.Delay(2000);
            label.Text = "UpdatedPullableContent";
            label.BackgroundColor = Color.Green
            pullToRefresh.IsRefreshing = false;
        }
    }
} 
```
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project. 