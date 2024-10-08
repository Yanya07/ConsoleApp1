using System;

class TemperatureSensor
{
    public event Action<int> TemperatureChanged;
    private int currentTemperature;

    public int CurrentTemperature
    {
        get { return currentTemperature; }
        set
        {
            if (currentTemperature != value)
            {
                currentTemperature = value;
                TemperatureChanged?.Invoke(currentTemperature);
            }
        }
    }
}

class Thermostat
{
    public void OnTemperatureChanged(int temperature)
    {
        if (temperature < 18)
        {
            Console.WriteLine("Температура низкая, включаем отопление.");
        }
        else if (temperature > 25)
        {
            Console.WriteLine("Температура высокая, выключаем отопление.");
        }
        else
        {
            Console.WriteLine("Температура в норме.");
        }
    }
}

class Program
{
    static void Main()
    {
        TemperatureSensor sensor = new TemperatureSensor();
        Thermostat thermostat = new Thermostat();

        // Подписка на событие
        sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

        // Изменение температуры
        sensor.CurrentTemperature = 16;
        sensor.CurrentTemperature = 22;
        sensor.CurrentTemperature = 27;
        Console.ReadLine();
    }
}
