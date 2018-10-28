using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hud : MonoBehaviour {

    private InventoryController inventory;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

    }
    // Use this for initialization
    void Start () {
        inventory = transform.Find("Panel/Inventory").gameObject.AddComponent<InventoryController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
