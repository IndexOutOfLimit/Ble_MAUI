﻿namespace Drrobo.Modules.RemotelyControlled.Views;

public partial class DroneView : ContentPage
{
	public DroneView()
	{
		InitializeComponent();

        SetDeviceDisplay();

        DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
    }

    private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
    {
        SetDeviceDisplay();
    }

    private async Task SetDeviceDisplay()
    {
        switch (DeviceDisplay.Current.MainDisplayInfo.Orientation)
        {
            case DisplayOrientation.Landscape:
                Joystick.IsVisible = true;
                JoystickWarning.IsVisible = false;
                break;
            case DisplayOrientation.Portrait:
                Joystick.IsVisible = false;
                JoystickWarning.IsVisible = true;
                break;
        }
    }

    void OpenCam(object sender, EventArgs args)
    {
        WebViewCam.IsVisible = true;
        ImageButtonCam.IsVisible = false;
    }
}