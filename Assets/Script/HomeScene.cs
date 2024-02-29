using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HomeScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScore;

    private void Awake()
    {
        // method 2 : Static Object
        highScore.text = GameData.Data.HighScore.ToString();
    }

    public void GotoPlayScene()
    {
        Debug.Log("Go to Play Scene");
        SceneManager.LoadScene("Gameplay");
    }
}
