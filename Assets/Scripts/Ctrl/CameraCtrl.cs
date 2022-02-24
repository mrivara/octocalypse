using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour {

    // Use this for initialization
    public Transform player;
    public bool bossCamera;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!bossCamera)
        {
            if (player.position.x >= 0 && player.position.y >= 0)
            { transform.position = new Vector3((player.position.x + 1), player.position.y, -10); }
            else
            { transform.position = new Vector3(transform.position.x, player.position.y, -10); }

            if (player.position.y <= 0)
            {
                transform.position = new Vector3((player.position.x + 1), 0, -10);
            }
        }
        else
        {
            if (player.position.x >= 86 && player.position.y >= 0)
            { transform.position = new Vector3((player.position.x + 3), player.position.y, -10); }
            else
            { transform.position = new Vector3(transform.position.x, player.position.y, -10); }

            if (player.position.y <= 0)
            {
                transform.position = new Vector3((player.position.x + 3), 0, -10);
            }
        }
    }
}
