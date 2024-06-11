using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : IService
{
    private Dictionary<System.Type, object> _services = new Dictionary<System.Type, object>();

    public ServiceLocator(AudioSource audioSource, AudioClip openClip, AudioClip closeClip)
    {
        var fadeService = new FadeService();
        var soundPlayer = new SoundPlayer(audioSource, openClip, closeClip);
        var playerPrefsSaver = new PlayerPrefsSaver();
        var jsonSaver = new JsonSaver();

        _services[typeof(IFadeService)] = fadeService;
        _services[typeof(ISoundPlayer)] = soundPlayer;
        _services[typeof(ISaver)] = playerPrefsSaver; // или jsonSaver
    }

    public T GetService<T>()
    {
        return (T)_services[typeof(T)];
    }
}
