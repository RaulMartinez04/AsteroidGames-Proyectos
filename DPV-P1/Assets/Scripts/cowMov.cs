using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowMov : MonoBehaviour
{
    public float speed;
    
    public AudioClip audio;
    public AudioSource audioS;

    private void Start(){
        audioS = this.GetComponent<AudioSource>();
    }




    // Update is called once per frame
    void FixedUpdate(){
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            //Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(audio,transform.position);
            Destroy(this.gameObject);
        }
    }

}
