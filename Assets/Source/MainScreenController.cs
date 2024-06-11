using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenController : IUIState
{
    private MainView _mainView;
    private UISwitcher _uiSwitcher;

    public MainScreenController(MainView mainView, UISwitcher uiSwitcher)
    {
        _mainView = mainView;
        _uiSwitcher = uiSwitcher;
    }

    public void Enter()
    {
        _mainView.SubscribeOpenButton(OpenAdditionalPanel);
    }

    public void Exit()
    {
        _mainView.UnsubscribeOpenButton(OpenAdditionalPanel);
    }

    private void OpenAdditionalPanel()
    {
        _uiSwitcher.ShowAdditionalPanel();
    }
}
