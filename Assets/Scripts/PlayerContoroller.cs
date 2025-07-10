using UnityEngine;

public class PlayerContoroller : MonoBehaviour
{
    CharacterController controller; // <- дл€ физики, если прыжки ху€рить будем

    [SerializeField] public int value;
    [Space]
    [SerializeField] private Vector3 playerVelocity;
    [SerializeField] private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravityValue = -9.81f;
    void Start()
    {
        value = 0;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        controller.Move(transform.TransformDirection(Vector3.forward) * speed);
    }

    private void Jump()
    {
        controller.velocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
    }
}
