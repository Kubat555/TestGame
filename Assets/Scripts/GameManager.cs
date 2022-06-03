using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int winCoinsCount = 10;
    public int gameOverTimer = 15;

    [SerializeField] private GameObject menu;
    [SerializeField] private Text menuText;


    void Awake()
    {
        Instance = this;
        GlobalEventManager.Win.AddListener(WinGame);
        GlobalEventManager.Lose.AddListener(LoseGame);
    }
    private void WinGame()
    {
        Time.timeScale = 0f;
        menuText.text = "WIN";
        menu.SetActive(true);
    }

    private void LoseGame()
    {
        Time.timeScale = 0f;
        menuText.text = "LOSE";
        menu.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
