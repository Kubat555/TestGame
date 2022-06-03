using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent<int> OnCoinCount = new UnityEvent<int>();
    public static UnityEvent<int> TimerPlus = new UnityEvent<int>();

    public static UnityEvent Win = new UnityEvent();
    public static UnityEvent Lose = new UnityEvent();
    public static UnityEvent Spawn = new UnityEvent();

    public static void GetCoinCount(int winCount)
    {
        OnCoinCount.Invoke(winCount);
    }

}
