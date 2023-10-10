using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UI
{
    public class DisplayScore : MonoBehaviour
    {
        [Header("Score")]
        private TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GameManager.instance.OnScoreChanged += HandleOnScore;
            HandleOnScore();
        }

        private void OnDisable()
        {
            GameManager.instance.OnScoreChanged -= HandleOnScore;
        }

        private void HandleOnScore(int score = 0)
        {
            _scoreText.text = "Score: " + score.ToString();
        }
    }
}
