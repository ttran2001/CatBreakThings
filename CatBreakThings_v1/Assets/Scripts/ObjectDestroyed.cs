using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyed : MonoBehaviour
{

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Cat"){
            Destroy(this.gameObject); 
        }
    }
}
