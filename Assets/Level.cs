using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public int lev = 1;
    void OnTriggerEnter2D(Collider2D check)
    {
        if(check.CompareTag("Player"))
        {
            SceneManager.LoadScene(lev);
        }
    }
}
