using Openome.Enums;
using System;
using System.Timers;

namespace Openome.Models
{
    public class Metronome
    {
        public int BPM { get; private set; }
        public int Duration { get; private set; }
        public int Frequency { get; private set; }
        public Compass Subdivisions { get; private set; }

        private Timer timer;
        private readonly int beepDuration = 10;
        private bool isRunning = false;

        public Metronome(int bpm = 60, int duration = 60000, int frequency = 440, Compass subdivisions = Compass.Semibreve)
        {
            BPM = bpm;
            Duration = duration;
            Frequency = frequency;
            Subdivisions = subdivisions;
            timer = new Timer();
            timer.Elapsed += Tick;
            timer.Enabled = false;
        }

        private void Tick(object? sender, EventArgs e)
        {
            Console.Beep(Frequency, beepDuration);
        }

        public void Start()
        {
            isRunning = true;
            timer.Interval = CalculateInterval();
            timer.Start();
        }

        public void Stop()
        {
            isRunning = false;
            timer.Stop();
        }

        private double CalculateInterval()
        {
            double interval = 60000 / BPM;
            return interval;
        }
    }
}
