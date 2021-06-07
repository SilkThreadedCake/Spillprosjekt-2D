using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Sound : MonoBehaviour
{
    private string folder;

    public List<AudioClip> audioManager;
    public float volume;
    AudioSource audios;

    private void Start()
    {
        audios = GetComponent<AudioSource>();
        
    }

    public void PlaySound1(int audioID)
    {
            audios.PlayOneShot(audioManager[audioID], volume);
    }
}
