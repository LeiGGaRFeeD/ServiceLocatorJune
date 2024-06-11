using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip openClip;
    [SerializeField] private AudioClip closeClip;
    [SerializeField] private UISwitcher uiSwitcher;

    private void Awake()
    {
        var serviceLocator = new ServiceLocator(audioSource, openClip, closeClip);
        uiSwitcher.Init(serviceLocator);
    }
}
