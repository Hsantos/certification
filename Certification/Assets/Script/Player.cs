using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("PLAYER COLLIDE  : " +  other);
        if (other.gameObject.GetComponent<Item>())
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level2");
        }
    }
}
