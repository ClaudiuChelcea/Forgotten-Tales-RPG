using Mirror;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NetworkHUD : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField field;

    public void Host()
    {
        NetworkManager.singleton.StartHost();
    }

    public void Client()
    {
        NetworkManager.singleton.StartClient();
    }

    public void ServerOnly()
    {
        NetworkManager.singleton.StartServer();
    }

    public void SetIPAddress()
    {
        NetworkManager.singleton.networkAddress = field.text;
    }
}
