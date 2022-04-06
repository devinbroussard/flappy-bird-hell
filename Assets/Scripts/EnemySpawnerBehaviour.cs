using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject _playerObject;
    [SerializeField]
    GameObject _enemyObject;
    float _timer = 5;
    [SerializeField]
    float _spawnCooldown = 1;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnCooldown)
        {
            float yPosition = Random.Range(15, -15);
            GameObject enemy = Instantiate(_enemyObject);
            enemy.transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);

            EnemyBehaviour enemyBehaviour = enemy.GetComponent<EnemyBehaviour>();
            enemyBehaviour.Player = _playerObject;

            _timer = 0;
        }
    }
}
