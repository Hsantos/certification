using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Startup : MonoBehaviour {

    public Button btPlay;

	void Start () 
    {
        
        btPlay.onClick.AddListener(PlayGame);
	}
	
    private void PlayGame()
    {
        SceneManager.LoadScene("Persistent", LoadSceneMode.Additive);
        SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
   
    }
}
