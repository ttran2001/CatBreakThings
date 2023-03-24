using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    static public bool goalMet = false; 


    void OnTriggerEnter(Collider other){
    // If the Cat Asset collides with the goal, it will set the goalMet to true and change color
        if(other.gameObject.tag == "Cat"){
            Goal.goalMet = true; 
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color; 
            c.a=1; 
            mat.color=c;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); // Load the next scene of the game. Last screen it will load is the Game Over scene
        }
    }
}
