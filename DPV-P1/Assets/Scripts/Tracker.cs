using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tracker : MonoBehaviour
{
    public int contadorCoches;
    public int contadorVacas;
    public TMP_Text tmp;
    public TMP_Text puntajeVacas;
    
    // Start is called before the first frame update
    void Start()
    {
        contadorCoches = 0;
        tmp.text = "0";
        contadorVacas = 0;
    }

    //Update is called once per frame
    private void OnTriggerExit(Collider other){
      if(other.gameObject.tag == "coche"){
        contadorCoches++;
        tmp.text = contadorCoches.ToString();
      }  
    }
    
    private void OnTriggerEnter(Collider other){
      if(other.gameObject.tag == "vaca"){
        contadorVacas++;
        puntajeVacas.text = contadorVacas.ToString();
      }  
    }
}
