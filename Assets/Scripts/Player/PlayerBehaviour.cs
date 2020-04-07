using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameManager gameManager;

    public float velocity = 1f;

    private Rigidbody2D _rB;

    private AudioManager _audioManager;

    private void Awake()
    {
        _rB = GetComponent<Rigidbody2D>();
        _audioManager = GameObject.Find("Audio Manager").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rB.velocity = Vector2.up * velocity;
            _audioManager.WingAudio();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        _audioManager.DieAudio();
    }
}
