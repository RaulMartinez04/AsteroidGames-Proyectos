using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCar : MonoBehaviour{


    /* private void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.tag == "coche") {
             Destroy(collision.gameObject);
         }

     }*/

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "coche") {
            Destroy(other.gameObject);
        }
    }


}
