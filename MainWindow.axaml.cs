using Avalonia.Controls;
using CefNet.Avalonia;

namespace AvaloniaApp
{
    public partial class MainWindow : Window
    {
        public const string FontFamily = "Microsoft YaHei,Simsun,ƻ��-��,����-��";
        public MainWindow()
        {
            InitializeComponent();
            tb.FontFamily = FontFamily;
            //var view = new WebView();
            var view = new CustomWebView();
            view.InitialUrl = "https://www.baidu.com";
            web.Children.Add(view);
        }
    }
}
