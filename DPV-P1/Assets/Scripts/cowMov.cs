using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowMov : MonoBehaviour
{
    public float speed;
    public int gold;

    // Update is called once per frame
    void FixedUpdate(){
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
