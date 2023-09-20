using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour{
    private float vm;
    private float hm;
    public float speed, rotationSpeed;

    public int gold;

    // Update is called once per frame
    void Update(){
        hm = Input.GetAxis("Horizontal");
        vm = Input.GetAxis("Vertical");
        this.transform.Translate(Time.deltaTime * speed * hm, 0,0);
        //this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * hm);

    }

    /*private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Caja"){
            Destroy(collision.gameObject);
            gold++;
        }
    }*/
}
