﻿namespace BMICalculator;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void CalculateBMI_Pressed(object sender, EventArgs e)
	{
		var heightInMeter = heightSlider.Value * 100;
		var weightInkg = WeightSlider.Value;

		var bmi = weightInkg / (heightInMeter * heightInMeter);

    }

}

