using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace controlsDemo
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

        private void Tb_textbox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((bool)Tb_textbox.IsChecked)
            {
                ResultText.Text = "Yes";
            }
            else
            {
                ResultText.Text = "No";
            }
        }

        private void Rb_RadioButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((bool)Rb_RadioButton.IsChecked)
            {
                Rb_ResultText.Text = "Yes";
            }
            else
            {
                Rb_ResultText.Text = "No";
            }
        }

        private void Cb_ComboBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var cbControl = (ComboBox)sender;
            var Item = (ComboBoxItem)cbControl.SelectedItem;
            Cb_TextBox.Text = Item.Content.ToString();
        }

        private void Cbox_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
            if (null == CbText_ListBox) return;
            var lbControl = (ListBox)sender;
            if (null == lbControl) return;
            var Lb_item = (ListBoxItem)lbControl.SelectedItem;
            if (null == Lb_item) return;
            if (null == Lb_item.Content) return;
            CbText_ListBox.Text = Lb_item.Content.ToString();
            */
            var selectItem = Cbox_ListBox.Items.Cast<ListBoxItem>()
                .Where(p => p.IsSelected)
                .Select(t => t.Content.ToString())
                .ToArray();
            CbText_ListBox.Text = string.Join(",", selectItem);

        }

        private void tb_ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Tg_textValue.Text = tb_ToggleButton.IsChecked.ToString();
        }
    }
}
