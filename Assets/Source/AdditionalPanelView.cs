using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdditionalPanelView : MonoBehaviour
{
    [SerializeField] private Button closeButton;

    public void SubscribeCloseButton(UnityEngine.Events.UnityAction action)
    {
        closeButton.onClick.AddListener(action);
    }

    public void UnsubscribeCloseButton(UnityEngine.Events.UnityAction action)
    {
        closeButton.onClick.RemoveListener(action);
    }
}
