using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
    }
}
