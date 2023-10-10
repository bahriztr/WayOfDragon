using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] private int score;

    public static GameManager instance { get; private set; }
    public event System.Action<int> OnScoreChanged;

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
        OnScoreChanged?.Invoke(score);
    }

    public void RestartGame()
    {
        score = 0;
        Time.timeScale = 1f;
        StartCoroutine(RestartGameCoroutine());
    }

    private IEnumerator RestartGameCoroutine()
    {
        yield return SceneManager.LoadSceneAsync("Level1");
    }
}
