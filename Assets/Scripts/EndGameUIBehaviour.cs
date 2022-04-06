using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameUIBehaviour : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
