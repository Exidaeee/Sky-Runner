using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb != null ) Debug.LogWarning("PlayerController needs a Rigidbody2D.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector2 moveInput = Vector2.zero;


        if (Keyboard.current.wKey.isPressed)
        {
            moveInput.y = 1f;
        }
        if(Keyboard.current.sKey.isPressed )
        {
            moveInput.y = -1f;
        }

        Vector2 movement = moveInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position+movement);
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {   

        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);         
            FindFirstObjectByType<GameManager>().GameOver();
        }
    }

}
