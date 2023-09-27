using Openome.Commands;
using Openome.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Openome.ViewModels
{
    public class MetronomeViewModel : BaseViewModel
    {
        public MetronomeViewModel()
        {
            Openome = new Metronome();
        }

        #region Properties

        private Metronome _openome;
        public Metronome Openome
        {
            get => _openome;
            set => _openome = value;
        }

        private int _bpValue;
        public int BpmValue
        {
            get => _bpValue;
            set
            {
                _bpValue = value;
                OnPropertyChanged(nameof(BpmValue));
            }
        }

        #endregion

        #region Commmands

        private ICommand _startCommand;
        public ICommand StartCommand =>
            _startCommand ??= new RelayCommand(exec => StartMetronome());

        private ICommand _stopCommand;
        public ICommand StopCommand =>
            _stopCommand ??= new RelayCommand(exec => StopMetronome());

        private ICommand _decrementBpmCommand;
        public ICommand DecrementBpmCommand =>
            _decrementBpmCommand ??= new RelayCommand(exec => DecrementBpm());

        private ICommand _incrementBpmCommand;
        public ICommand IncrementBpmCommand =>
            _incrementBpmCommand ??= new RelayCommand(exec => IncrementBpm());

        #endregion

        #region Methods

        private void StartMetronome()
        {
            Openome.Start();
        }

        private void StopMetronome()
        {
            Openome.Stop();
        }

        private void DecrementBpm()
        {
            if (BpmValue > 1)
                BpmValue--;
        }

        private void IncrementBpm()
        {
            if (BpmValue < 500)
                BpmValue++;
        }

        #endregion
    }
}
