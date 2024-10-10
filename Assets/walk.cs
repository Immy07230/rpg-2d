using UnityEngine;

public class walk : StateMachineBehaviour
{
    
}
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;       
   
    public Rigidbody2D rb;              

    private Vector2 movement;           
    private bool isGrounded;            
    private bool canDoubleJump;         
    public Transform groundCheck;       
    public float groundCheckRadius = 0.2f; 
    public LayerMask groundLayer;      

    public PlayerMovement(LayerMask groundLayer)
    {
        this.groundLayer = groundLayer;

    }
}

