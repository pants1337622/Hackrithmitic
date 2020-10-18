using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public CoinSpawner coinSpawner;
    public AudioSource coin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            coin.Play();
            Destroy(this.gameObject);
            coinSpawner.coin = coinSpawner.coin + 1;
        }
    }
}
