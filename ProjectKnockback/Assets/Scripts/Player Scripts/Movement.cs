using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Keys
    [SerializeField] private KeyCode UpKey;
    [SerializeField] private KeyCode LeftKey;
    [SerializeField] private KeyCode RightKey;
    [SerializeField] private KeyCode DownKey;
    
    // Plug ins
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform player;
    // Movement Values
    [SerializeField] private float JumpStrength;
    [SerializeField] private float moveSpeed;
    private string currentState = "Grounded";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MovementInput()
    {
        if (currentState == "Grounded")
        {
            if (Input.GetKeyDown(UpKey))
            {
                rb.AddForce(Vector3.up * JumpStrength, ForceMode.Impulse);
            }
            if (Input.GetKeyDown(LeftKey))
            {
                player.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            } else if (Input.GetKeyDown(RightKey))
            {
                player.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
        }
    }
}
