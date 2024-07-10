/*
 * Created by SharpDevelop.
 * User: aleksei.tertychnyi
 * Date: 7/10/2024
 * Time: 2:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Web.WebView2.Wpf;
using System.IO;


namespace AirQualityRead
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
			InitializeWebView();
		}
		private async void InitializeWebView()
        {
            await webview.EnsureCoreWebView2Async(null);

            // Construct the URI for the local file
            string localFilePath = Path.Combine(Environment.CurrentDirectory, "interface", "index.html");
            Uri uri = new Uri("file:///" + localFilePath.Replace("\\", "/"));

            // Set the Source property of the WebView2 control
            webview.Source = uri;
		}
	}
}