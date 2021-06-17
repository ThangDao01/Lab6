namespace Lab6_2
{
    public class Thermostat
    {
        public delegate void TemperatureChangeHandler(
            float newTemperature);

// Define the event publisher
        private TemperatureChangeHandler _onTemperatureChange;
        public TemperatureChangeHandler OnTemperatureChange
        {
            get { return _onTemperatureChange; }
            set { _onTemperatureChange = value; }
        }
        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set
            {
                if (value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
// Call subscribers
                    if (OnTemperatureChange!=null)
                    {
                        OnTemperatureChange(value);
                    }
                }
            }
        }
        private float _CurrentTemperature;
    }
}