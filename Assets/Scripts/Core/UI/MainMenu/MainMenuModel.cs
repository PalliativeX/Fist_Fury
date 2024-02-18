using Core.Gameplay;
using Core.Levels;
using Core.Menu;
using Core.Sound;

namespace Core.UI.MainMenu
{
	public sealed class MainMenuModel
	{
		private readonly LevelsHelper _levelsHelper;
		private readonly PanelController _panelController;
		private readonly VehicleSelectionService _vehicleSelection;
		private readonly SoundService _sound;

		public MainMenuModel(LevelsHelper levelsHelper, PanelController panelController, VehicleSelectionService vehicleSelection, SoundService sound)
		{
			_levelsHelper = levelsHelper;
			_panelController = panelController;
			_vehicleSelection = vehicleSelection;
			_sound = sound;
		}

		public void OnPlay() => _levelsHelper.Play(1);
		
		public bool IsSoundActive() => _sound.IsSoundActive;

		public void ToggleSoundActive() => _sound.ToggleActive();

		public void SelectPreviousVehicle() => _vehicleSelection.SelectPrevious();
		public void SelectNextVehicle() => _vehicleSelection.SelectNext();
		public bool IsOwned() => _vehicleSelection.IsOwned(_vehicleSelection.GetSelectedName());
		public (VehicleConfig, bool) GetVehicleData() => _vehicleSelection.GetVehicleData();
		public bool Buy() => _vehicleSelection.BuySelected();
		public (int, int) GetVehicleIndex()
		{
			(int, int) data = _vehicleSelection.GetVehicleIndex();
			data.Item1 += 1;
			return data;
		}
	}
}
