using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other)
   {
       Debug.Log("Ouch!");
   }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
               Debug.Log("Got package");
        }

        if(other.tag == "Customer")
        {
            Debug.Log("Package delivered!");
        }
    }
}
