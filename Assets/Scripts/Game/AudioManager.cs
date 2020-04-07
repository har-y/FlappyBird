using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip audioWing;
    public AudioClip audioPoint;
    public AudioClip audioDie;

    private AudioSource _audio;

    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WingAudio()
    {
        _audio.PlayOneShot(audioWing);
    }

    public void PointAudio()
    {
        _audio.PlayOneShot(audioPoint);
    }

    public void DieAudio()
    {
        _audio.PlayOneShot(audioDie);
    }
}
