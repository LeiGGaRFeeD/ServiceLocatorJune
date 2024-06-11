using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : ISoundPlayer
{
    private AudioSource _audioSource;
    private AudioClip _openClip;
    private AudioClip _closeClip;

    public SoundPlayer(AudioSource audioSource, AudioClip openClip, AudioClip closeClip)
    {
        _audioSource = audioSource;
        _openClip = openClip;
        _closeClip = closeClip;
    }

    public void PlayOpenSound()
    {
        _audioSource.PlayOneShot(_openClip);
    }

    public void PlayCloseSound()
    {
        _audioSource.PlayOneShot(_closeClip);
    }
}
