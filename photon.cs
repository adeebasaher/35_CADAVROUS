using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class PlayerLogin : MonoBehaviourPunCallbacks
{
 
    public string roomName;
    public GameObject cameraPrefab;
    public Transform cameraAvatar;
    
    private void Start( )
    { 
        // Connect to Photon Cloud
        PhotonNetwork.ConnectUsingSettings();

    }



    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon Cloud.");
        // Now you can log in your player using a custom method
        LoginPlayer( );
    }

private string myuname = "Sathvik"; 
    public void LoginPlayer( )
    {
        Debug.Log("trying to login with username " + myuname);
        if (string.IsNullOrEmpty(myuname))
        {
            Debug.LogError("Player name is empty.");
            return;
        }

        // Set the player's name
        PhotonNetwork.NickName = myuname;

        // Attempt to join a random room or create one if none is available
        PhotonNetwork.JoinOrCreateRoom(roomName, new RoomOptions { MaxPlayers = 4 }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("You have joined the classroom : " + "VRIMS" );
        // tstmsg.ShowToast("You have joined the classroom!" + roomName);
        // canMove = true;
        GameObject arms = PhotonNetwork.Instantiate(cameraPrefab.name, cameraPrefab.transform.position, cameraPrefab.transform.rotation);
        // arms.name = ButtonClickHandlerHome.username;

        // arms.GetComponentInChildren<TextMeshProUGUI>().text = ButtonClickHandlerHome.username;
        // arms.transform.SetParent(playerAvatar, false);

    }
    // public override void OnPlayerEnteredRoom(Player newPlayer)
    // {
    //     Debug.Log("New player entered the room: " + newPlayer.NickName);
    //     tstmsg.ShowToast("New player entered the room: " + newPlayer.NickName);

    //     GameObject arms = PhotonNetwork.Instantiate(playerPrefab.name, playerPrefab.transform.position, playerPrefab.transform.rotation);
        
    //     arms.name = newPlayer.NickName;
    //     arms.GetComponentInChildren<TextMeshProUGUI>().text = newPlayer.NickName;
        

    // }
}