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
        Debug.Log("���� �õ� ��..");
    }

    // ���� ���� �Ǹ� ȣ��Ǵ� �޼���
    public override void OnConnectedToMaster()
    {
        Debug.Log("���� ����.");
        base.OnConnectedToMaster();
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;

        PhotonNetwork.JoinOrCreateRoom("Room 1", roomOptions, TypedLobby.Default);
    }

    // �濡 ���� �Ǹ� ȣ��Ǵ� �޼���
    public override void OnJoinedRoom()
    {
        Debug.Log("�濡 ����");
        base.OnJoinedRoom();
    }

    // �濡 ���ο� �÷��̾ ������ ȣ��Ǵ� �޼���
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("���ο� �÷��̾� ����");
        base.OnPlayerEnteredRoom(newPlayer);
    }

    // �濡�� �ٸ� �÷��̾ ������ ȣ��Ǵ� �޼���
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log("�÷��̾� �Ѹ��� �������ϴ�.");
        base.OnPlayerLeftRoom(otherPlayer);
    }
}
