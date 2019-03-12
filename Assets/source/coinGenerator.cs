using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinGenerator : MonoBehaviour
{
    public GameObject coinPrefab;

    public int numberOfCoins;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfCoins; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, +levelWidth);
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
