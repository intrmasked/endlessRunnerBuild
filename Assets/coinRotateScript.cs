using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotateScript : MonoBehaviour
{
    public float turnSpeed = 90;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("CoinCollection"))
        {
            Destroy(gameObject);
            
        }
    }

    private void Update()
    {
        transform.Rotate(0,turnSpeed * Time.deltaTime,0);
    }
}
