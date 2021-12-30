using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource clipAS;
    public AudioSource clipAS2;
    public AudioSource musicAS;
    public AudioClip[] clips;
    public void PlayOnce(AudioClip newClip) { clipAS.clip = newClip; clipAS.Play(); }
    public void PlayOnce(int newClip) { PlayOnce(clips[newClip]); }
    public void PlayOnce2(AudioClip newClip) { clipAS2.clip = newClip; clipAS2.Play(); dead=true;}
    public void PlayOnce2(int newClip) { PlayOnce2(clips[newClip]); }
    public void setMusic(AudioClip newClip) { musicAS.clip = newClip; musicAS.Play(); musicAS.UnPause(); }
    public void setMusic(int newClip) { setMusic(clips[newClip]); }

    private bool dead = false;
    private bool dead_c = false;
    private float dead_time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dead && !dead_c) {
            dead_time = Time.time;
            dead_c = true;
        }
        if (dead_c && Time.time - dead_time > 9)
            Application.LoadLevel("menu");
    }
}
