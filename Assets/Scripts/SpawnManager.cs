using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    [SerializeField]
    private int maxPlatforms = 20;
    [SerializeField]
    private GameObject platform;
    [SerializeField]
    private float horizontalMin = 6.5f,
        horizontalMax = 14f,
        verticalMin = -6f,
        verticalMax = 6f;

    private Vector2 originPosition;

	// Use this for initialization
	void Start ()
    {
        originPosition = transform.position;
        Spawn();
	}
	
	private void Spawn()
    {
        for (int i = 0; i <maxPlatforms; i++)
        {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;
        }
    }
}
