namespace TempConvert
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(CelsiusEntry.Text, out double celsius))
            {
                double fahrenheit = UnitConverters.CelsiusToFahrenheit(celsius);
                FahrenheitEntry.Text = $"{fahrenheit:F2}";
            }
            else
            {
                // Handle invalid input (e.g., non-numeric values).
                ErrorTextField.Text = "Invalid input. Please enter a valid Celsius temperature.";
            }
        }

        private void SwitchDirectionClicked(object sender, EventArgs e)
        {
            count++;
            ErrorTextField.Text = $"Switch direction button pressed {count} times";
        }
    }

}
