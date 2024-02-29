using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GamePlayScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI highScore;

    private void Awake()
    {
        ResetScore();
    }

    private void ResetScore()
    {
        GameData.Data.ResetScore();
        RefreshScore();
    }

    private void RefreshScore()
    {
        currentScore.text = GameData.Data.CurrentScore.ToString();
        highScore.text = GameData.Data.HighScore.ToString();
    }

    public void AddScore(int score)
    {
        GameData.Data.AddScore(score);
        RefreshScore();
    }

    public void GotoHomeScene()
    {
        Debug.Log("Go to Home Scene");
        SceneManager.LoadScene("Home");
    }
}
