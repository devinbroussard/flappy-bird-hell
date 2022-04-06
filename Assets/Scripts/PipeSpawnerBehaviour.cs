using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _pipeObject;

    [SerializeField]
    private float _spawnTime = 2.0f;
    private float _lastSpawnTime = 0.0f;

    public float SpawnTime { get => _spawnTime; }

    private void Update()
    {

        if (_spawnTime <= Time.time - _lastSpawnTime)
        {
            _lastSpawnTime = Time.time;
            float yPos = Random.Range(30, 10);

            GameObject topPipe = Instantiate(_pipeObject, null);
            topPipe.transform.position = new Vector3(40, yPos, 0);

            GameObject bottomPipe = Instantiate(_pipeObject, null);
            bottomPipe.transform.position = new Vector3(40, yPos - 55, 0);
        }
    }
}
