using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupLevel : MonoBehaviour {

    private void Awake()
    {
        GameObject player =  Instantiate(Resources.Load("Prefab/Player")) as GameObject;
        gameObject.AddComponent<CameraLogic>().AddTarget(player.transform);
    }
}
