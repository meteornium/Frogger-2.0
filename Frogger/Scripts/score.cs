using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int Score = 0;

    public Text scoreText;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "FroggerGameScreen")
        {
            Score = 0;
        }
    }

    private void Update()
    {
        scoreText.text = Score.ToString();
    }
}
