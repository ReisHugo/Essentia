using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Vector3 objectVelocity;
    private bool groundedObject;
    private float gravityValue = -9.81f;
    private CharacterController _controller;

    public void Init(CharacterController controller)
    {
        _controller = controller;
    }
        
    public void CreateGravity()
    {
        groundedObject = _controller.isGrounded;
        
        if (groundedObject && objectVelocity.y < 0)
        {
            objectVelocity.y = 0f;
        }

        objectVelocity.y += gravityValue * Time.deltaTime;
        _controller.Move(objectVelocity * Time.deltaTime);
    }
}