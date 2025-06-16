using UnityEngine;

public class FlappyController : MonoBehaviour
{
    public float jumpForce = 8f; // Força do pulo (aumentada)
    public float forwardSpeed = 2f; // Velocidade horizontal constante

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Pulo com espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f); // zera só a velocidade Y
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        // Movimento horizontal constante
        rb.linearVelocity = new Vector2(forwardSpeed, rb.linearVelocity.y);
    }
}