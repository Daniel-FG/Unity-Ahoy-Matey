using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour
{
	void Update ()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        float xpos = CrossPlatformInputManager.GetAxis("Horizontal");
        float zpos = CrossPlatformInputManager.GetAxis("Vertical");
        transform.position = new Vector3(transform.position.x + xpos, transform.position.y, transform.position.z + zpos);
	}

    public override void OnStartLocalPlayer()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
