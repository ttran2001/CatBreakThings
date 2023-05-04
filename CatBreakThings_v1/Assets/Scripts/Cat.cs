using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public static float bottomY = -3.369995f;
    public static bool dead = false; 

    void Update (){
        if(transform.position.y < bottomY){
            dead = true;
            Destroy(this.gameObject); 
        }
    }
    
}
