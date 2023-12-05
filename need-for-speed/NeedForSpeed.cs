using System;

class RemoteControlCar
{
    private readonly int _speed;
    private readonly int _batteryDrain;
    private int _distanceDriven;
    private int _battery;
    public int BatteryDrain => _batteryDrain;
    public int Speed => _speed;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _battery = 100;
    }

    public bool BatteryDrained() => _battery == 0 || (_battery - _batteryDrain) < 0;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if (BatteryDrained())
        {
            return;
        }
        
        _distanceDriven += _speed;
        _battery -= _batteryDrain;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
    
    
}


class RaceTrack
{
    private readonly int _distance;
    
    public RaceTrack(int distance)
    {
        _distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car) => _distance <= (100 / car.BatteryDrain) * car.Speed;
}