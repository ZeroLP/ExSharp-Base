using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExSharpBase.Modules;

namespace ExSharpBase.Events
{
    class Base
    {
        private static Base Instance { get; set; } = new Base();
        private static Timer Ticker;

        private Base()
        {
            Ticker = new Timer(0.1f);
            Ticker.Elapsed += OnTickElapsed;
            Ticker.Start();
            Instance = this;
        }

        public static ToggleResult Toggle(TickElapsed Value)
        {
            if (OnTick != null)
            {
                foreach (TickElapsed s in OnTick.GetInvocationList())
                {
                    if (s == Value)
                    {
                        OnTick -= Value;
                        return ToggleResult.Disabled;
                    }
                }
            }
            OnTick += Value;
            return ToggleResult.Enabled;
        }

        internal static event TickElapsed OnTick;

        private static void OnTickElapsed(object Sender, TimerElapsedEventArgs e)
        {
            OnTick?.Invoke();
        }
    }

    public enum ToggleResult
    {
        Disabled,
        Enabled,
    }

    public delegate void TickElapsed();
}
