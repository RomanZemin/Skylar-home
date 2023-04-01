using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows;
using System;

namespace Skylar_home
{
    public partial class MainWindow : Window
    {
        private void panelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                ListViewItem selectedItem = e.AddedItems[0] as ListViewItem;

                if (selectedItem != null)
                {
                    switch (selectedItem.Name)
                    {
                        case "HideMenuItem":
                            DoubleAnimation animation_side = new DoubleAnimation();
                            DoubleAnimation animation_main = new DoubleAnimation();
                            if (hidden)
                            {
                                animation_side.From = 55;
                                animation_main.From = mainpanelWidth + 185;
                                animation_main.To = mainpanelWidth;
                                animation_side.To = sidepanelWidth;
                                animation_side.Duration = new Duration(TimeSpan.FromSeconds(1));
                                animation_main.Duration = new Duration(TimeSpan.FromSeconds(1));
                                sidePanel.BeginAnimation(WidthProperty, animation_side);
                                mainPanel.BeginAnimation(WidthProperty, animation_main);
                                hidden = false;
                            }
                            else
                            {
                                animation_main.From = mainpanelWidth;
                                animation_main.To = mainpanelWidth + 185;
                                animation_side.From = sidepanelWidth;
                                animation_side.To = 55;
                                animation_side.Duration = new Duration(TimeSpan.FromSeconds(1));
                                animation_main.Duration = new Duration(TimeSpan.FromSeconds(1));
                                sidePanel.BeginAnimation(WidthProperty, animation_side);
                                mainPanel.BeginAnimation(WidthProperty, animation_main);
                                hidden = true;
                            }
                            break;
                        case "OverviewMenuItem":
                            MyTabControl.SelectedItem = OverviewTabItem;
                            break;
                        case "AssistantMenuItem":
                            MyTabControl.SelectedItem = AssistantTabItem;
                            break;
                        case "DevicesMenuItem":
                            MyTabControl.SelectedItem = DevicesTabItem;
                            break;
                        case "AnalyticsMenuItem":
                            MyTabControl.SelectedItem = AnalyticsTabItem;
                            break;
                        case "RulesMenuItem":
                            MyTabControl.SelectedItem = RulesTabItem;
                            break;
                        case "GalleryMenuItem":
                            MyTabControl.SelectedItem = GalleryTabItem;
                            break;
                        case "HistoryMenuItem":
                            MyTabControl.SelectedItem = HistoryTabItem;
                            break;
                        case "SettingsMenuItem":
                            MyTabControl.SelectedItem = SettingsTabItem;
                            break;
                    }
                }
            }
        }
    }
}