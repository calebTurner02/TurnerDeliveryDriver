using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{

[SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
[SerializeField] Color32 hasNoPackageColor = new Color32(1, 1, 1, 1);
[SerializeField] float fltdestroyDelay = 0.5f;
    bool bolHasPackage;


    SpriteRenderer spriteRenderer;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
               spriteRenderer.color = hasPackageColor;
               Destroy(other.gameObject, fltdestroyDelay);
        }

        if(other.tag == "Customer" && bolHasPackage)
        {
            Debug.Log("Package delivered!");
            bolHasPackage = false; 
            spriteRenderer.color = hasNoPackageColor;
        }
    }
}
