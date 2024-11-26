﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
        int objectIndex = Random.Range(0, objectPrefabs.Length);
       

        // If game is still active, spawn new object
        if (playerControllerScript.gameOver == false)
        {
            Debug.Log("Here " + objectIndex);
            Instantiate(objectPrefabs[objectIndex], spawnLocation, objectPrefabs[objectIndex].transform.rotation);
        }

    }
}