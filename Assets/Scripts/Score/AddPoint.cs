using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    private Score _score;
    private AudioManager _audioManager;

    // Start is called before the first frame update
    void Start()
    {
        _score = GameObject.Find("Game Manager").GetComponent<Score>();
        _audioManager = GameObject.Find("Audio Manager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _score.score++;
        _audioManager.PointAudio();
    }
}
