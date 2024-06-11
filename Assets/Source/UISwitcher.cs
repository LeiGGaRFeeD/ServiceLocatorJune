using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UISwitcher : MonoBehaviour
{
    [SerializeField] private GameObject mainScreen;
    [SerializeField] private GameObject additionalPanel;
    private IFadeService _fadeService;
    private ISoundPlayer _soundPlayer;
    private IService _serviceLocator;

    private IUIState _currentState;
    private MainScreenController _mainScreenController;
    private AdditionalPanelController _additionalPanelController;

    public void Init(IService serviceLocator)
    {
        _serviceLocator = serviceLocator;
        _fadeService = serviceLocator.GetService<IFadeService>();
        _soundPlayer = serviceLocator.GetService<ISoundPlayer>();

        var mainView = mainScreen.GetComponent<MainView>();
        var additionalPanelView = additionalPanel.GetComponent<AdditionalPanelView>();

        _mainScreenController = new MainScreenController(mainView, this);
        _additionalPanelController = new AdditionalPanelController(additionalPanelView, this, serviceLocator);

        ShowMainScreen();
    }

    public void ShowMainScreen()
    {
        _currentState?.Exit();
        _currentState = _mainScreenController;
        _currentState.Enter();

        mainScreen.SetActive(true);
        additionalPanel.SetActive(false);
    }

    public void ShowAdditionalPanel()
    {
        _currentState?.Exit();
        _currentState = _additionalPanelController;
        _currentState.Enter();

        mainScreen.SetActive(false);
        additionalPanel.SetActive(true);
        _soundPlayer.PlayOpenSound();
        var image = additionalPanel.GetComponent<Image>();
        _fadeService.FadeIn(image, 1f);
    }

    public void HideAdditionalPanel()
    {
        var image = additionalPanel.GetComponent<Image>();
        _fadeService.FadeOut(image, 1f).OnComplete(() =>
        {
            mainScreen.SetActive(true);
            additionalPanel.SetActive(false);
            _soundPlayer.PlayCloseSound();
        });
    }
}
