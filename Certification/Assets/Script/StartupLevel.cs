using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupLevel : MonoBehaviour
{

    private Player player;
    private Item item;

    private void Awake()
    {
        player = ((GameObject) Instantiate(Resources.Load("Prefab/Player"))).AddComponent<Player>();
        gameObject.AddComponent<CameraLogic>().AddTarget(player.transform);
        

        item = ((GameObject)Instantiate(Resources.Load("Prefab/Item"))).AddComponent<Item>();
        item.transform.localPosition = new Vector3(0, 0.8f, -10);
        item.transform.localScale = Vector3.one*0.5f;
    }
}
