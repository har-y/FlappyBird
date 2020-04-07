using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverPanel;
    public GameObject menuPanel;
    public GameObject scorePanel;

    public AudioClip audioWing;

    public Animator animator;

    private AudioSource _audio;

    private Score score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Score>();
        _audio = GetComponent<AudioSource>();
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ActiveTime()
    {
        Time.timeScale = 1;
    }

    private void InactiveTime()
    {
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        InactiveTime();
        gameoverPanel.SetActive(true);
        scorePanel.SetActive(false);
        animator.Play("ScoreBoard");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void Play()
    {
        ActiveTime();
        menuPanel.SetActive(false);
        scorePanel.SetActive(true);
    }

    public void GameStart()
    {
        InactiveTime();
        menuPanel.SetActive(true);
    }

    public void WingAudio()
    {
        _audio.clip = audioWing;
        _audio.Play();
    }
}
