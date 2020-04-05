using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverPanel;
    public GameObject menuPanel;


    // Start is called before the first frame update
    void Start()
    {

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
    }

    public void MenuButton()
    {
        gameoverPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void Play()
    {
        ActiveTime();
        menuPanel.SetActive(false);
    }
}
