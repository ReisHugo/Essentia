using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    private CharacterController _controller;
    private MainCharacterMovement mainCharacterMovement;
    private Gravity gravity;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();

        mainCharacterMovement = gameObject.AddComponent<MainCharacterMovement>();
        mainCharacterMovement.Init(_controller);

        gravity = gameObject.AddComponent<Gravity>();
        gravity.Init(_controller);
    }

    private void FixedUpdate()
    {
        gravity.CreateGravity();

        mainCharacterMovement.IsRunning = Input.GetKey(KeyCode.LeftShift);
        mainCharacterMovement.Move();
    }
}