using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score;
    public static GameManager instance { get; private set; }

    private void Awake()
    {
        SingletonThisGameObject();
    }
     
    private void SingletonThisGameObject()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
            Destroy(this.gameObject);
    }

    public void IncreaseScore()
    {
        score += 10;
    }

    public void RestartGame()
    {
        StartCoroutine(RestartGameCoroutine());
    }

    private IEnumerator RestartGameCoroutine()
    {
        yield return SceneManager.LoadSceneAsync("Level1");
    }
}
