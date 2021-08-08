using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class trailManager : MonoBehaviour
{
    public GameObject tile;
    public GameObject refrencObject;
    public float distanceBetweenTile = 4.0f;
    public int maxTileAmount = 50;
    public float randomValue = 0.8f;

    private Vector3 prevTilePos;
    
    private Vector3 direction = new Vector3(0, 0, 1);
    private Vector3 mainDir = new Vector3(0, 0, 1);
    private Vector3 otherDir = new Vector3(1, 0, 0);
    private int thisTileAmount = 0;
    void Start()
    {
        prevTilePos = refrencObject.transform.position;
        
        
        
    }

    private void Awake()
    {
        GameStatic1.TrailManager = this;
    }

    private void Update()
    {   
        
        if(thisTileAmount > maxTileAmount) return;
        
        Debug.Log(thisTileAmount);
        if (Random.value < randomValue)
        {
            direction = mainDir;
        }
        else if (thisTileAmount %5 == 0)
        {
            Vector3 tmp = direction;
            direction = otherDir;
            mainDir = direction;
            otherDir = tmp;
            
        }

        Vector3 spawnPos = prevTilePos + distanceBetweenTile * direction;
       
        Instantiate(tile, spawnPos, Quaternion.Euler(0, 0, 0));
        prevTilePos = spawnPos;
        thisTileAmount++;
    }

    public void DecreaseAmount()
    {
        thisTileAmount--;
    }
}
