using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject cameraFocusPoint;
    public GameObject playerPrefab;
    public Vector3[] playerSpawnPoints;

    void Start()
    {
        PlayerInput player1Input = GetComponent<PlayerInputManager>().JoinPlayer(1, 1, "Player 1 Control", Keyboard.current);
        PlayerInput player2Input = GetComponent<PlayerInputManager>().JoinPlayer(2, 2, "Player 2 Control", Keyboard.current);

        player1Input.gameObject.transform.position = playerSpawnPoints[0];
        player2Input.gameObject.transform.position = playerSpawnPoints[1];

        cameraFocusPoint.GetComponent<CameraFocusPoint>().players.Add(player1Input.gameObject);
        cameraFocusPoint.GetComponent<CameraFocusPoint>().players.Add(player2Input.gameObject);
    }
}
