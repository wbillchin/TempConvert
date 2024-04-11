namespace TempConvert
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        bool convertToF = true;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if( convertToF == true )
            {
                if (double.TryParse(CelsiusEntry.Text, out double celsius))
                {
                    ErrorTextField.Text = ""; // clear the error message

                    double fahrenheit = UnitConverters.CelsiusToFahrenheit(celsius);
                    FahrenheitEntry.Text = $"{fahrenheit:F2}";
                }
                else
                {
                    // Handle invalid input (e.g., non-numeric values).
                    ErrorTextField.Text = "Invalid input. Please enter a valid Celsius temperature.";
                }
            } else
            {
                if (double.TryParse(FahrenheitEntry.Text, out double fahrenheit))
                {
                    ErrorTextField.Text = ""; // clear the error message

                    double celsius = UnitConverters.FahrenheitToCelsius(fahrenheit);

                    CelsiusEntry.Text = $"{celsius:F2}";
                }
                else
                {
                    // Handle invalid input (e.g., non-numeric values).
                    ErrorTextField.Text = "Invalid input. Please enter a valid ftemperature.";
                }
            }
        }

        private void SwitchDirectionClicked(object sender, EventArgs e)
        {
            convertToF = !convertToF;

            if (convertToF == true)
            {
                ConversionToggle.Text = ">";
                ErrorTextField.Text = "Switch direction to F";
            }
            else
            {
                ConversionToggle.Text = "<";
                ErrorTextField.Text = "Switch direction to C";

            }
        }
    }

}
