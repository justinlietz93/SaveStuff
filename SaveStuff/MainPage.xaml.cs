﻿namespace SaveStuff;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void Save_OnClicked(object sender, EventArgs e)
    {
        Preferences.Set("Username",txtUsername.Text); //Key Value pair
    }

    private void Read_OnClicked(object sender, EventArgs e)
    {
        txtUsername.Text = Preferences.Get("Username", "");
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtUsername.Text = string.Empty;
    }
}