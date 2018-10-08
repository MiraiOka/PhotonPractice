using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonManager : MonoBehaviour {

	void Start()
    {
        Debug.Log("Startした");

        //Photonに接続する
        PhotonNetwork.ConnectUsingSettings(null);
    }

    //ロビーに入ると呼ばれるメソッド
    void OnJoinedLobby()
    {
        Debug.Log("ロビーに入りました");

        //ルームに入室する
        PhotonNetwork.JoinRandomRoom();
    }

    //ルームに入室すると呼ばれるメソッド
    void OnJoinedRoom()
    {
        Debug.Log("ルームへ入室しました");
    }

    //ルームの入室に失敗すると呼ばれる
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("ルームの入室に失敗しました");

        //ルームがないと入室に失敗するため、その時は自分で作る
        //引数でルーム名を指定できる
        PhotonNetwork.CreateRoom("myRoomName");
    }
}
