using MahApps.Metro;
using MahApps.Metro.Controls;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace WordByWord
{
    /// <summary>
    /// Interaction logic for Colors.xaml
    /// </summary>
    public partial class Colors : MetroWindow
    {
        public Colors()
        {
            InitializeComponent();
        }

        private void ColorsComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Tuple<AppTheme, Accent> theme = ThemeManager.DetectAppStyle(Application.Current);
            string selectedColor = (ColorsComboBox.SelectedItem as ComboBoxItem).Content.ToString();

            if (Application.Current != null)
                ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent(selectedColor), theme.Item1);
        }
    }
}
