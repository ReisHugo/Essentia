using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
    private float _walkSpeed = 1.5f;
    private float _runSpeed = 3f;
    public bool IsRunning;
    private CharacterController _controller;

    public void Init(CharacterController controller)
    {
        _controller = controller;
        IsRunning = false;
    }

    public void Move()
    {
        if (IsRunning)
            CharacterMove(_runSpeed);
        else
            CharacterMove(_walkSpeed);
    }

    public void CharacterMove(float speed)
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        _controller.Move(move * Time.deltaTime * speed);
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}