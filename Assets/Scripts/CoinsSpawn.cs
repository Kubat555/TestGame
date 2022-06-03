using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinsSpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> coinsPoint;

    [SerializeField] private GameObject coin;

    private int oldPosition = -1;
    private int random = -1;

    private void Start()
    {
        SpawnCoin();
        GlobalEventManager.Spawn.AddListener(SpawnCoin);
    }

    private void SpawnCoin()
    {
        while(oldPosition == random)
        {
            random = Random.Range(0, coinsPoint.Count);
        }
        oldPosition = random;
        Instantiate(coin, coinsPoint[random].transform.position, Quaternion.identity);

    }
}
