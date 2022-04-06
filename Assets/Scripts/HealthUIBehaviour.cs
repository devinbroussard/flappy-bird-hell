using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthUIBehaviour : MonoBehaviour
{
    [SerializeField]
    private Text _healthText;
    [SerializeField]
    private GameObject _player;
    private PlayerHealthBehaviour _playerHealthBehaviour;

    private void Start()
    {
        _playerHealthBehaviour = _player.GetComponent<PlayerHealthBehaviour>();
    }

    private void Update()
    {
        int health = _playerHealthBehaviour.Health;
        if (health < 0) 
            health = 0;

        _healthText.text = $"Hits left: {health}";

        if (health <= 0)
            SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
