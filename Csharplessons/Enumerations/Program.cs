var temperature = new Temperature(TemperatureUnit.Celcius, 10);
Console.WriteLine($"Temp: {temperature.ValueInCelsius.ToString("0.0")} °C");
enum TemperatureUnit
{
    Celcius,
    Fahrenheit,
    Kelvin,
    Test
}

class Temperature
{

    public Temperature(TemperatureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }
    public TemperatureUnit Unit { get; set; }
    public decimal Value { get; set; }
    public decimal ValueInCelsius
    {
        get
        {
            // SWITCH EXPRESSION of the switch statement / better than switch expression

            return Unit switch
            {
                TemperatureUnit.Celcius => Value,
                TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
                TemperatureUnit.Kelvin => Value - 273.15m,
                _=> 0 // discard 
            };


            // swtich statemnt of the if statement 
            //switch (Unit)
            //{
            //    case TemperatureUnit.Celcius:
            //        return Value;
            //    case TemperatureUnit.Fahrenheit:
            //        return (Value - 32) * 5 / 9;
            //    case TemperatureUnit.Kelvin:
            //        return Value - 273.15m;
            //    default:
            //        return 0;
            //}
            //===================================================
            //if (Unit == TemperatureUnit.Celcius)
            //{
            //    return Value;
            //}
            //if (Unit == TemperatureUnit.Fahrenheit)
            //{
            //    return (Value - 32) * 5 / 9;
            //}
            //if (Unit == TemperatureUnit.Kelvin)
            //{
            //    return Value - 273.15m;
            //}
            //return 0;
        }
    }
}