using UnityEngine;

public class CarController : MonoBehaviour
{
    // setting min and max speed so that they can be used as a range for car speed to be randomly set in
    public Rigidbody2D rb;
    public float minSpeed = 12f;
    public float maxSpeed = 16f;
    float speed = 1f;

    // sets cars speed to a random float within the range
    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // setting a variable called forward to a vector2, allowing us to use transform.
    // cannot do this to a base vector2, and transform typically wants a vector3 object
    // using this to work around that and manipulate the direction the car moves "forward"
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);

        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
}
