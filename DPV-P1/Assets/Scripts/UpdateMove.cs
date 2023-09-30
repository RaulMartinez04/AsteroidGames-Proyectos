using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour{
    private float vm;
    private float hm;
    public float speed, rotationSpeed;

    public GameObject screen, camera;

    public AudioClip audio;
    public AudioSource audioS;

    public Rigidbody rb;
    public float upForce = 5;

    private void Start(){
        audioS = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
        hm = Input.GetAxis("Horizontal");
        vm = Input.GetAxis("Vertical");
        this.transform.Translate(Time.deltaTime * speed * hm, 0,0);
        //this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * hm);

        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Salto");
            rb.AddForce(Vector3.up*upForce);
        }

    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "coche"){
            screen.SetActive(true);
            camera.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
