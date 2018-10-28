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

        SceneManager.sceneLoaded += OnSceneLoaded;
   
    }

    private void OnSceneLoaded(Scene current, LoadSceneMode mode)
    {
        //Hud

        GameObject[] all = current.GetRootGameObjects();
        for (int i = 0; i < all.Length; i++)
        {
            if (current.name == "Level1" || current.name == "Level2")
            {
                if (all[i].GetComponent<Camera>())
                {
                    all[i].AddComponent<StartupLevel>();
                    break;
                }
            }
            else if(current.name == "Persistent")
            {
                if (all[i].GetComponent<Canvas>())
                {
                    all[i].AddComponent<Hud>();
                    break;
                }
            }
        }
    }
}
