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
    public int turnDir;
    public GameObject Coins;
    
    void Start()
    {
       
        
        
    }

    private void Awake()
    {
        GameStatic1.TrailManager = this;
    }

    private void Update()
    {   
        
        if(thisTileAmount > maxTileAmount) return;
        
   
         
       
        if (Random.value < randomValue )
        {
            direction = mainDir;
            turnDir++;
        }
        else if (turnDir >= 10)
        {
           
            Vector3 tmp = direction;
            direction = otherDir;
            mainDir = direction;
            otherDir = tmp;
        
            turnDir = 0;
        }
        
       

        Vector3 spawnPos = prevTilePos + distanceBetweenTile * direction * 1;
        if(thisTileAmount%6 == 0)
        {
            Vector3 coinPos = new Vector3(spawnPos.x, spawnPos.y + Random.Range(2, 3), spawnPos.z);
            Instantiate(Coins,coinPos , Quaternion.Euler(90,0,0));

        }
        Instantiate(tile, spawnPos, Quaternion.Euler(0, 0, 0));
        prevTilePos = spawnPos;
        thisTileAmount++;
    }

    public void DecreaseAmount()
    {
        thisTileAmount--;
    }


    
}
