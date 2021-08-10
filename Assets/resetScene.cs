using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
       
            StartCoroutine(GameOver());
        
    }

    IEnumerator GameOver()
    {   
        Debug.Log("gameOverS");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("SampleScene");
    }
}
