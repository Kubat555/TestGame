using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int seconds = 15;
    private Text timerText;
    void Start()
    {
        seconds = GameManager.Instance.gameOverTimer;
        timerText = GetComponent<Text>();
        timerText.text = seconds.ToString();
        GlobalEventManager.TimerPlus.AddListener(SecondsPlus);
        StartCoroutine(TimerCoroutine());
    }

    private IEnumerator TimerCoroutine()
    {
        while(seconds > 0)
        {
            timerText.text = seconds.ToString();
            yield return new WaitForSeconds(1);
            seconds--;
            timerText.text = seconds.ToString();
        }
        GlobalEventManager.Lose.Invoke();
    }

    private void SecondsPlus(int amount)
    {
        seconds = Mathf.Clamp(seconds + amount, 0, GameManager.Instance.gameOverTimer + 1);
    }
}
