using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Debug.Log("YOU WIN!");
        SceneManager.LoadScene("FroggerWinScreen");
    }
}
