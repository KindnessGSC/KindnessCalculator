using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace KindnessCalculator.Model
{
    public class ButtonHandler
    {
        private TextBox _resultTextBox;

        public ButtonHandler(UIElementCollection layout)
        {
            _resultTextBox = layout[0] as TextBox;
            foreach (UIElement element in layout)
            {
                Button button = element is Button ? element as Button : null;
                if(button != null) button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.Source;
            //double fisrtNum, lastNum;

            if (_resultTextBox.Text[0] == '0' && button.Content.ToString() != "," && !_resultTextBox.Text.Contains(","))
            {
                _resultTextBox.Text = button.Content.ToString();
            }
            else
            {
                if (button.Content.ToString() == "," && _resultTextBox.Text.Contains(","))
                    return;

                _resultTextBox.Text += button.Content.ToString();
            }

        }
    }
}
