using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCollector : MonoBehaviour
{
    int points = 0;
   void  OnTriggerEnter2D(Collider2D other)
    {
        points = points +10;
        Debug.Log("Puntos " + points);

        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
        }
    }






}
