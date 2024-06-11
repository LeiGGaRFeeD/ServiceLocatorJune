using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField] private Button openButton;

    public void SubscribeOpenButton(UnityEngine.Events.UnityAction action)
    {
        openButton.onClick.AddListener(action);
    }

    public void UnsubscribeOpenButton(UnityEngine.Events.UnityAction action)
    {
        openButton.onClick.RemoveListener(action);
    }
}
