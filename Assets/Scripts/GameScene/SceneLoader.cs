using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Snake _snake;

    private void OnEnable()
    {
        _snake.Touched += Lose;
    }

    private void OnDisable()
    {
        _snake.Touched -= Lose;
    }

    private void Lose()
    {
        SceneManager.LoadScene("FailScreen");
    }

}
