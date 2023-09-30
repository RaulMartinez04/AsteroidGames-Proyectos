using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnV : MonoBehaviour{

    public GameObject[] spwans = new GameObject[8];
    public GameObject[] cars = new GameObject[2];

    int s, c;


    // Start is called before the first frame update
    void Start(){
        
        for (int i = 0; i < 4; i++) {
            s = Random.Range(0, 8);
            c = Random.Range(0, 2);
            Instantiate(cars[c], spwans[s].transform.position, spwans[s].transform.rotation);
        }
    }


}
