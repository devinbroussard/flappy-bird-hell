using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementBehaviour : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private float _timeAlive = 10;
    private float _timer = 0;


    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();    
    }

    private void FixedUpdate()
    {
        _timer += Time.deltaTime;

        if (_timer >= _timeAlive)
            Destroy(gameObject);

        _rigidBody.MovePosition(transform.position - new Vector3(0.3f, 0, 0));
    }
}
