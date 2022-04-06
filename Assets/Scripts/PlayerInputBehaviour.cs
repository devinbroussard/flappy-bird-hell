using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovementBehaviour;

    private void Awake()
    {
        _playerMovementBehaviour = GetComponent<PlayerMovementBehaviour>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumped!");
            _playerMovementBehaviour.MoveDirection = Vector3.up;
        }
        else _playerMovementBehaviour.MoveDirection = new Vector3(0, 0, 0);
    }
}
