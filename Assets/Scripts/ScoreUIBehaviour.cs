using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUIBehaviour : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    [SerializeField]
    private PipeSpawnerBehaviour _pipeSpawner;
    private int _score;
    private float _cooldown;
    private float _timer = -0.5f;

    private void Start()
    {
        _cooldown = _pipeSpawner.SpawnTime;
    }
    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _cooldown)
        {
            _score++;
            _timer = 0;
        }
        _scoreText.text = $"Score: {_score}";
    }
}
