using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    private float startScale; //= Vector3.one * 0.2f;

    [SerializeField] public int value;

    [Space]
    
    [SerializeField] private Vector3 playerVelocity;
                     private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravityValue = -9.81f;

    [Space]

    [SerializeField] private Transform transform;

    void Start()
    {
        //transform = GetComponent<Transform>();
        startScale = transform.localScale.x;
        value = 0;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        
        if (groundedPlayer && Keyboard.current.spaceKey.IsPressed())
        {
            Jump();
        }
        playerVelocity.y += gravityValue * Time.deltaTime;

        Move();

    }

    private void Move()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 1);
        Vector3 finalMove = (move * playerSpeed) + (playerVelocity.y * Vector3.up);
        controller.Move(finalMove * Time.deltaTime);
    }

    private void Jump()
    {
        playerVelocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravityValue);
    }

    public void setSize()
    {
        float finalScale = startScale + startScale * ((float)value / 100.0f);
        finalScale = Mathf.Clamp(finalScale, 0.01f, 0.4f);
        transform.localScale = Vector3.one * finalScale;
        Debug.Log(finalScale);
        Debug.Log(transform.localScale);
        Debug.Log("-----------");
    }

}
