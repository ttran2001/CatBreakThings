using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TutorialMenu : MonoBehaviour
{
    public void TutorialButton(){
        SceneManager.LoadScene("Start Screen 1"); // Goes back to the start menu once user click the "Back to Menu" button in the tutorial scene
    }
}
