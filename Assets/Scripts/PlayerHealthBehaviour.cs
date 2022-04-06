using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBehaviour : MonoBehaviour
{
    [SerializeField]
    private int _health;
    private float _timer;
    [SerializeField]
    /// <summary>
    /// The invincibility frames a player gets after taking damage
    /// </summary>
    private float _damageCooldown = 1.0f;

    public int Health { get => _health; }

    /// <summary>
    /// Makes the player take damage
    /// </summary>
    public void TakeDamage()
    {
        if (_timer >= _damageCooldown)
        {
            _health--;
            _timer = 0;
        }
    }
    private void Update()
    {
        _timer += Time.deltaTime;

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
