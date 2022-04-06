using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private GameObject _player;
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidBody;

    public GameObject Player { get => _player; set => _player = value; }

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 movementDirection = (_player.transform.position - transform.position).normalized;

        _rigidBody.velocity = movementDirection * _speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealthBehaviour playerHealth = other.GetComponent<PlayerHealthBehaviour>();

            if (playerHealth)
                playerHealth.TakeDamage();

            Destroy(gameObject);
        }

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
