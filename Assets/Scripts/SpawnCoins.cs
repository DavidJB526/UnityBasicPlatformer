using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour {

    [SerializeField]
    private Transform[] coinSpawns;
    [SerializeField]
    private GameObject coin;

	// Use this for initialization
	void Start ()
    {
        Spawn();
	}
	
	private void Spawn()
    {
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 2);
            if (coinFlip > 0)
            {
                Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
            }
        }
    }
}
