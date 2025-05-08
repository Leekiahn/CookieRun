using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private bool isGameOver = false;

    [Header("난이도 설정")]
    public float difficultyIncreaseInterval = 10f; // 난이도 상승 주기 (초)
    public float obstacleSpawnRate = 2f; // 초기 스폰 간격 (초)
    public float obstacleSpeed = 5f; // 초기 장애물 속도
    public float playerReactionWindow = 1f; // 초기 반응 시간 (초)

    [Header("난이도 변화량")]
    public float spawnRateDecrease = 0.1f;
    public float speedIncrease = 0.5f;
    public float reactionWindowDecrease = 0.05f;

    [Header("게임 오버 UI")]
    public GameObject gameOverPanel;
    public Text scoreText;

    private int score = 0;
    private float timeSinceLastDifficultyIncrease;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Update()
    {
        timeSinceLastDifficultyIncrease += Time.deltaTime;

        if (timeSinceLastDifficultyIncrease >= difficultyIncreaseInterval)
        {
            IncreaseDifficulty();
            timeSinceLastDifficultyIncrease = 0f;
        }
    }

    private void IncreaseDifficulty()
    {
        // 스폰 간격 줄이되 최소값 보장
        obstacleSpawnRate = Mathf.Max(0.5f, obstacleSpawnRate - spawnRateDecrease);

        // 속도는 계속 증가 가능
        obstacleSpeed += speedIncrease;

        // 반응 시간은 너무 낮아지지 않게 최소값 보장
        playerReactionWindow = Mathf.Max(0.3f, playerReactionWindow - reactionWindowDecrease);

        Debug.Log($"난이도 상승! 스폰간격: {obstacleSpawnRate}, 속도: {obstacleSpeed}, 반응 시간: {playerReactionWindow}");
    }

    public void AddScore(int value)
    {
        if (!isGameOver)
        {
            score += value;
        }
    }

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;

        // 게임 정지
        Time.timeScale = 0f;

        // UI 표시
        gameOverPanel.SetActive(true);
        scoreText.text = $"Score: {score}";
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    //GameOverPanel GameManager연결해주세요.
    //GameOverUI속 Button에 GameManager.RestartGame()연결해주세요 
}
