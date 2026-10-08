using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction playerControlls;
    [SerializeField] InputAction playerAttack;
    [SerializeField] float playerSpeed = 10f;
    [SerializeField] GameObject bubbleSpawn, bubblePrefab;
    [SerializeField] private AudioClip shootSound;
    Rigidbody2D rb;
    Collider2D collider;
    Vector2 moveDirection;
    
    
    private void OnEnable()
    {
        playerControlls.Enable();
        playerAttack.Enable();
    }

    private void OnDisable()
    {
        playerControlls.Disable();
        playerAttack.Disable();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = playerControlls.ReadValue<Vector2>();

        if (playerAttack.WasPressedThisFrame())
        {
            Attack();
        }
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        //moveDirection.y = 0;
        rb.linearVelocity = playerSpeed *  moveDirection;
    }

    void Attack()
    {
        AudioManager.Instance.PlaySound(shootSound);
        Instantiate(bubblePrefab, bubbleSpawn.transform.position, Quaternion.identity);
    }
}
