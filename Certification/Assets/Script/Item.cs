using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ITEM COLLIDE  : " + other);
        if (other.gameObject.GetComponent<Player>())
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
