using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    //TODO: TP2 - Remove unused methods/variables/classes
    public static SoundManager Instance;
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource effectSource;
    [SerializeField] public AudioClip button;

    public void PlaySound(AudioClip clip)
    {
        effectSource.PlayOneShot(clip);
    }

    //TODO: Fix - Should be native Setter/Getter
    public AudioSource GetMusicSource()
    {
        return musicSource;
    }
    public void ToggleAudio()
    {
        effectSource.mute = !effectSource.mute;
        musicSource.mute = !musicSource.mute;
        PlaySound(button);
    }

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

}
