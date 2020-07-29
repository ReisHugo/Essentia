using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    private CharacterController _controller;
    private MainCharacterMovement mainCharacterMovement;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        mainCharacterMovement = gameObject.AddComponent<MainCharacterMovement>();
        mainCharacterMovement.Init(_controller);        
    }

    private void FixedUpdate()
    {       
        mainCharacterMovement.IsRunning = Input.GetKey(KeyCode.LeftShift);
        mainCharacterMovement.Move();
    }
}