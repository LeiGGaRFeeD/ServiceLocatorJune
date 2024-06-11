using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AdditionalPanelController : IUIState
{
    private AdditionalPanelView _additionalPanelView;
    private UISwitcher _uiSwitcher;
    private ISaver _saver;
    private Score _score;

    public AdditionalPanelController(AdditionalPanelView additionalPanelView, UISwitcher uiSwitcher, IService serviceLocator)
    {
        _additionalPanelView = additionalPanelView;
        _uiSwitcher = uiSwitcher;
        _saver = serviceLocator.GetService<ISaver>();
        _score = additionalPanelView.GetComponent<Score>();
    }

    public void Enter()
    {
        _additionalPanelView.SubscribeCloseButton(ClosePanel);
    }

    public void Exit()
    {
        _additionalPanelView.UnsubscribeCloseButton(ClosePanel);
        _saver.SaveScore(_score.GetScore());
    }

    private void ClosePanel()
    {
        _uiSwitcher.HideAdditionalPanel();
    }
}
