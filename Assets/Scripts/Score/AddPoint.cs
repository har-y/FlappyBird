using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    private Score _score;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _score = GameObject.Find("Game Manager").GetComponent<Score>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _score.score++;
        _gameManager.PointAudio();
    }
}
