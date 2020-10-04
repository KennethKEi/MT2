using Photon.Pun;
using System.IO;
using UnityEngine;

public class GameSetupController : MonoBehaviour
{
    // This script will be added to any multiplayer scene
    void Start()
    {
        CreatePlayer(); //Create a networked player object for each player that loads into the multiplayer scenes.
    }

    private void CreatePlayer()
    {
        Debug.Log("Creating Player");
<<<<<<< HEAD
<<<<<<< HEAD
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "box"), Vector3.zero, Quaternion.identity);
=======
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer"), Vector3.zero, Quaternion.identity);
>>>>>>> parent of 428ee29... Characters animation synced now
=======
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer"), Vector3.zero, Quaternion.identity);
>>>>>>> parent of 428ee29... Characters animation synced now
    }
}
