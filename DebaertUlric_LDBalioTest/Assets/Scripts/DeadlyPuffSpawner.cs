using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyPuffSpawner : MonoBehaviour
{
    public Vector2 spawnRateRandom;
    private float currentTime;

    public Transform[] firePos;

    public GameObject puffPrefab;

    void Start()
    {
        currentTime = Random.Range(spawnRateRandom.x, spawnRateRandom.y); 
    }


    void Update()
    {
        Timer();
    }

    void Timer()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0)
        {
            SpawnPuff();
            currentTime = Random.Range(spawnRateRandom.x, spawnRateRandom.y);
        }
    }

    void SpawnPuff()
    {
        int id = Random.Range(0, firePos.Length-1);
        Instantiate(puffPrefab, firePos[id]);
    }
}
