using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogController : MonoBehaviour
{
    // fairly straightforward. if this button is pressed, do this.
    public Rigidbody2D rb;
    private bool hasMoved = false;
    Vector2[] lastTwoPositions = new Vector2[2];

    private void Start()
    {
        lastTwoPositions[0] = rb.position;
        lastTwoPositions[1] = rb.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
            score.Score += 100;
            hasMoved = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
            score.Score += 100;
            hasMoved = true;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
            score.Score += 100;
            hasMoved = true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
            score.Score += 100;
            hasMoved = true;
        }

        if (hasMoved)
        {
            lastTwoPositions[0] = lastTwoPositions[1];
            lastTwoPositions[1] = rb.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Car")
        {
            Debug.Log("You lose!");
            SceneManager.LoadScene("FroggerEndScreen");
        }

        if (collision.tag == "Border")
        {
            rb.MovePosition(lastTwoPositions[0]);
        }
    }

    public void StopMovement()
    {
        
    }
}
