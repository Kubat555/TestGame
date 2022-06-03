using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    [SerializeField] private int addSeconds = 5;
    [SerializeField] private ParticleSystem particle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GlobalEventManager.GetCoinCount(GameManager.Instance.winCoinsCount);
            GlobalEventManager.TimerPlus.Invoke(addSeconds);
            GlobalEventManager.Spawn.Invoke();
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
