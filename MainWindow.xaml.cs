
using System;
using System.Windows;

namespace LB_5 {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) {
            try {
                var start = Convert.ToDouble(this.Start.Text);
                var end = Convert.ToDouble(this.End.Text);
                var jump = Convert.ToDouble(this.Jump.Text);
                var table = new Table();
                table.Generate(start, end, jump);
                
                ListBox.Items.Clear();
                foreach (var point in table.Points.ToArray()) {
                    ListBox.Items.Add(point.GetInfo());
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}