using UnityEngine;

public class PlayerMovementMobile : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;        // Increased a bit for better feel

    private Vector2 moveDirection = Vector2.zero;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()           // Changed from FixedUpdate for better input
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);
    }

    void HandleInput()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x > 0)
                moveDirection = Vector2.right;
            else
                moveDirection = Vector2.left;
        }
        else
        {
            moveDirection = Vector2.zero;     // Stop when finger released
        }
    }

    // For buttons if you use them
    public void PlatformMove(float x)
    {
        moveDirection = new Vector2(x, 0);
    }
}