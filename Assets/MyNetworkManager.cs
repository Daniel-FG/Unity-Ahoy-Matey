using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager
{
    public void MyStartHost()
    {
        Debug.Log("Time StartHost: " + Time.timeSinceLevelLoad);
        StartHost();
    }
    public void MyStartClient()
    {
        Debug.Log("Time StartHost: " + Time.timeSinceLevelLoad);
        StartClient();
    }
    public override void OnStartHost()
    {
        Debug.Log("Time OnStartHost: " + Time.timeSinceLevelLoad);
    }
    public override void OnStartClient(NetworkClient client)
    {
        Debug.Log("Start Client " + Time.timeSinceLevelLoad);
        InvokeRepeating("PrintDots", 0f, 1f);
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Client is connected to " + conn.address);
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
