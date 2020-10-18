using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public Vector3[] positions;
    public int coins;
    public Portal portalcode;
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(coins == 30)
        {
            portalcode.enabled = true;
        }
    }
    void CoinSpawn()
    {
        foreach(Vector3 place in positions)
        {
            Instantiate(coin, place, Quaternion.identity);
        }
    }
}
