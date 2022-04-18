using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ServerManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); 
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Servera bağlanıldı.");
        Debug.Log("Lobiye bağlanılıyor..");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("Lobiye bağlanıldı.");
        Debug.Log("Odaya bağlanılıyor..");
        PhotonNetwork.JoinOrCreateRoom("Normal Oda", new RoomOptions{MaxPlayers=2, IsOpen=true, IsVisible=true}, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log("Odaya bağlanıldı.");
        Debug.Log("Oyuncu oluşturuluyor..");
        PhotonNetwork.Instantiate("Karakter", new Vector3(0,0,0), Quaternion.identity, 0, null);
    }
}
