using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIleDestroy : MonoBehaviour
{

    public bool isGrounded;
    // Start is called before the first frame update

    private void Awake()
    {   
        
    }

    private void Start()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)transform.position.x + 10 < (int)GameStatic1.charGameObject.transform.position.x ||
            (int)transform.position.z + 10 < (int)GameStatic1.charGameObject.transform.position.z)
        {
            GameStatic1.TrailManager.DecreaseAmount();
            Destroy(gameObject);
        }
    }


  
}
