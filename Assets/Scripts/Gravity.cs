using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Vector3 playerVelocity;
    private bool groundedPlayer;
    private float gravityValue = -9.81f;
    public CharacterController controller;

    public void FixedUpdate()
    {
        CreateGravity();
    }
        
    void CreateGravity()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
    
}