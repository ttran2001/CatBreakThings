/*
using UnityEngine;
using System.Collections; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public enum GameMode{
    idle, 
    playing, 
    levelEnd
}

public class CatBreakThings : MonoBehaviour{
    static private CatBreakThings S; // a private Singleton 

    [Header("Set in Inspector")]
    public Text uitLevel; 
    public Text uitLives; 
    public GameObject[] levels;
    

    [Header("Set Dynamically")]
    public int level; 
    public int levelMax; 
    public int livesLeft = 3; 
    public GameObject current; 
    public GameMode mode = GameMode.idle; 
    
    void Start(){
        S = this; 
        level = 1;  
        levelMax = levels.Length; 
        StartLevel(); 
    }

    void StartLevel(){
        if(levels != null){
            Destroy(current);
        }
        GameObject[] gos =  GameObject.FindGameObjectWith;

        Goal.goalMet = false; 

        UpdateGUI(); 
        
        mode = GameMode.playing; 
    }

    void UpdateGUI(){
        // Show the data in the GUI Texts
        uitLevevl.text = "Level: " (level+1)+" of "+levelMax;
        uitLives.text = "Lives: "+livesLeft;
    }

    void Update(){
        UpdateGUI(); 

        // Check for level end
        if ((mode== GameMode.playing) && Goal.goalMet){
            // Change mode to stop checking for level end
            mode = GameMode.levelEnd; 
            Invoke("NextLevel", 2f);
        }
    }

    void NextLevel(){
        level++; 
        if(level == levelMax){
            level = 0;
        }
        StartLevel();
    }

    public static void LivesTaken(){
        S.livesLeft--; 

        if(livesLeft == 0){
            SceneManager.LoadScene("_Scene_0"); 
        }
    }
}
*/