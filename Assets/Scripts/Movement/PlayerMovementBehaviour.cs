using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce;
    private Rigidbody _rigidBody;
    private Vector3 _moveDirection;

    public Vector3 MoveDirection { get => _moveDirection; set => _moveDirection = value; }

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (MoveDirection.y == 1)
            _rigidBody.velocity = MoveDirection * _jumpForce;

        if (_rigidBody.transform.position.y < -60 ||  _rigidBody.transform.position.y > 60)
            SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.gameObject.CompareTag("Pipe"))
            SceneManager.LoadScene(sceneBuildIndex:1);
    }
}
