using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{
[SerializeField] float fltdestroyDelay = 0.5f;
    bool bolHasPackage;

   void OnCollisionEnter2D(Collision2D other)
   {
       Debug.Log("Ouch!");
   }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !bolHasPackage)
        {
               Debug.Log("Got package");
               bolHasPackage = true;
               Destroy(other.gameObject, fltdestroyDelay);
        }

        if(other.tag == "Customer" && bolHasPackage)
        {
            Debug.Log("Package delivered!");
            bolHasPackage = false; 
        }
    }
}
