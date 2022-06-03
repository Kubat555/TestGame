using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour
{
    private int count = 0;
    void Start()
    {
        GetComponent<Text>().text = count.ToString();
    }

    private void Awake()
    {
        GlobalEventManager.OnCoinCount.AddListener(CoinCount);
    }

    private void CoinCount(int winCount)
    {
        count++;
        GetComponent<Text>().text = count.ToString();
        if (count >= winCount)
        {
            Debug.Log("win");
            GlobalEventManager.Win.Invoke();
            return;
        }
    }
}
