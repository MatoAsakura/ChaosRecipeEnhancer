﻿using System.Windows;
using ChaosRecipeEnhancer.UI.View;

namespace ChaosRecipeEnhancer.UI.UserControls.SetTrackerOverlayDisplays;

/// <summary>
///     Interaction logic for VerticalStandardDisplay.xaml
/// </summary>
public partial class VerticalStandardDisplay
{
    #region Constructors

    public VerticalStandardDisplay(SettingsView settingsView, SetTrackerOverlayView setTrackerOverlay)
    {
        _settingsView = settingsView;
        _setTrackerOverlay = setTrackerOverlay;
        InitializeComponent();
    }

    #endregion

    #region Fields

    private readonly SetTrackerOverlayView _setTrackerOverlay;
    private readonly SettingsView _settingsView;

    #endregion

    #region Event Handlers

    private void OpenStashTabOverlay_Click(object sender, RoutedEventArgs e)
    {
        _settingsView.RunStashTabOverlay();
    }

    private void FetchButton_Click(object sender, RoutedEventArgs e)
    {
        _setTrackerOverlay.RunFetching();
    }

    private void ReloadFilterButton_Click(object sender, RoutedEventArgs e)
    {
        _setTrackerOverlay.ReloadItemFilter();
    }

    #endregion
}