using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioClip[] sounds;
    AudioSource source;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;    
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void ClickSound()
    {
        source.clip = sounds[0];
        source.Play();
    }
    public void GameOver()
    {
        source.PlayOneShot(sounds[1]);
    }
}
