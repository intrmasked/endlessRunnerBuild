using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public CharacterController CharacterController;
    private float gravity = -50f;
    private Vector3 velocity;
    public LayerMask Ground;
    public bool isGrounded;
    public float speed;
    private float horizontalInput;
    public float jumpHeight;
    private bool turnLeft;
    private bool turnRight;
    private void Start()
    {
    //    velocity = Vector3.forward;
    GameStatic1.charGameObject = gameObject;
    }

    private void Update()
    {
       
        // Vector3 tempPos = new Vector3(transform.position.x, 1.23f, transform.position.y);
        // transform.position = tempPos;
        
        isGrounded = Physics.CheckSphere(transform.position, 0.5f, Ground, QueryTriggerInteraction.Ignore);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;

        }
        
        
        CharacterController.Move(transform.forward * speed * Time.deltaTime) ;

        if (isGrounded &&  Input.GetButtonDown("Jump"))

        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2 * gravity);
        }


        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);


        if (turnLeft)
        {
            transform.Rotate(new Vector3(0,-90f,0));
            StartCoroutine(AbitSlow());
        }
        
        if (turnRight)
        {
            transform.Rotate(new Vector3(0,90f,0));
            StartCoroutine(AbitSlow());

        }
        
        
        CharacterController.Move(velocity * Time.deltaTime);
    }

    IEnumerator AbitSlow()
    {
        speed = 7;
        yield return  new WaitForSeconds(0.6f);
        speed = 14;
    }
}

    

  

