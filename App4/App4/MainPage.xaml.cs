using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace App4
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void jumparies(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(BlankPage1)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();

        }

        private void jumptotaurus(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Taurus)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptogemini(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Gemini)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptocancer(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Cancer)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptoleo(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Leo)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptoscorpio(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Scorpio)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptosagittarius(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Sagittarius)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptocapricorn(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Capricorn)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptoaquarius(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(BlankPage2)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptopisces(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Pisces)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptovirgo(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Virgo)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }

        private void jumptolibra(object sender, RoutedEventArgs e)
        {
            var rootFrame = new Frame();
            if (!rootFrame.Navigate(typeof(Libra)))
            {
                throw new Exception("Failed to create initial page");
            } // Place the frame in the current Window and ensure that it is active 
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }
    }
}
