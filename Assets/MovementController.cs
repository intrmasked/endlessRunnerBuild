using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private bool turnLeft, turnRight;
    private bool isjumping;
    public float speed = 7.0f;
    public CharacterController CharacterController;

    private void Awake()
    {
        GameStatic1.charGameObject = gameObject;
    }

    private void Update()
    {
        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);

        if (turnLeft)
        {
            transform.Rotate(new Vector3(0,-90f,0f));
        }
        else if (turnRight)
        {
            transform.Rotate(new Vector3(0,90f,0));
        }

       // CharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
            
       

        CharacterController.Move(transform.forward * speed * Time.deltaTime);
    }
}
