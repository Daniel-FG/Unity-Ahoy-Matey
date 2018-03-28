using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager
{
    private void Start()
    {

    }
    
    public void MyStartHost()
    {
        Debug.Log("Time StartHost: " + Time.timeSinceLevelLoad);
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log("Time OnStartHost: " + Time.timeSinceLevelLoad);
    }
}
