using Openome.Commands;
using Openome.Models;
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

        #endregion

        #region Commmands

        private ICommand _startCommand;
        public ICommand StartCommand =>
            _startCommand ??= new RelayCommand(exec => StartMetronome());

        private ICommand _stopCommand;
        public ICommand StopCommand =>
            _stopCommand ??= new RelayCommand(exec => StopMetronome());

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

        #endregion
    }
}
