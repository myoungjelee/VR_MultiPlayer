using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        ConnectedToServer();
    }
    private void ConnectedToServer()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("접속 시도 중..");
    }

    // 서버 접속 되면 호출되는 메서드
    public override void OnConnectedToMaster()
    {
        Debug.Log("서버 접속.");
        base.OnConnectedToMaster();
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;

        PhotonNetwork.JoinOrCreateRoom("Room 1", roomOptions, TypedLobby.Default);
    }

    // 방에 참가 되면 호출되는 메서드
    public override void OnJoinedRoom()
    {
        Debug.Log("방에 참가");
        base.OnJoinedRoom();
    }

    // 방에 새로운 플레이어가 들어오면 호출되는 메서드
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("새로운 플레이어 참가");
        base.OnPlayerEnteredRoom(newPlayer);
    }

    // 방에서 다른 플레이어가 나가면 호출되는 메서드
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log("플레이어 한명이 나갔습니다.");
        base.OnPlayerLeftRoom(otherPlayer);
    }
}
