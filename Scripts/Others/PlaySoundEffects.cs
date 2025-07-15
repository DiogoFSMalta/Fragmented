using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffects : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public void PlaySoundEffect()
    {
        source.PlayOneShot(clip);
    }
}
