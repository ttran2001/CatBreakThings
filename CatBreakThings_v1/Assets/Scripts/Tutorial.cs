using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Tutorial : MonoBehaviour
{
    public void TutorialMenu(){
        SceneManager.LoadScene("Tutorial Screen"); // Load the Tutorial screen if the user click the tutorial menu button
    }
}
