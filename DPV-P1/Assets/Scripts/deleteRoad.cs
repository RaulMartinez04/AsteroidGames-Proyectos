using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteRoad : MonoBehaviour{

    public GameObject track;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            Destroy(track, 1.0f);
        }
    }

}
