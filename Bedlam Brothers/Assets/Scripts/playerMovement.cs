using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public AudioSource source;
    public float moveSpeed = 1f;
    public GameObject playerOneTarget;
    public GameObject playerTwoTarget;
    public Transform objectToLookAt;
    public float maxTurnSpeed = 50f;

    public ControllerSupport controls;

    private Vector2 p1MoveInput;
    private Vector2 p2MoveInput;

    private bool p1RotateLeftHeld;
    private bool p1RotateRightHeld;
    private bool p2RotateLeftHeld;
    private bool p2RotateRightHeld;

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        controls.Enable();

        controls.Gameplay.P1Move.performed += OnP1Move;
        controls.Gameplay.P1Move.canceled += OnP1Move;

        controls.Gameplay.P2Move.performed += OnP2Move;
        controls.Gameplay.P2Move.canceled += OnP2Move;

        controls.Gameplay.P1RotateLeft.performed += OnP1RotateLeft;
        controls.Gameplay.P1RotateLeft.canceled += OnP1RotateLeft;

        controls.Gameplay.P1RotateRight.performed += OnP1RotateRight;
        controls.Gameplay.P1RotateRight.canceled += OnP1RotateRight;

        controls.Gameplay.P2RotateLeft.performed += OnP2RotateLeft;
        controls.Gameplay.P2RotateLeft.canceled += OnP2RotateLeft;

        controls.Gameplay.P2RotateRight.performed += OnP2RotateRight;
        controls.Gameplay.P2RotateRight.canceled += OnP2RotateRight;
    }

    private void OnDisable()
    {
        controls.Gameplay.P1Move.performed -= OnP1Move;
        controls.Gameplay.P1Move.canceled -= OnP1Move;

        controls.Gameplay.P2Move.performed -= OnP2Move;
        controls.Gameplay.P2Move.canceled -= OnP2Move;

        controls.Gameplay.P1RotateLeft.performed -= OnP1RotateLeft;
        controls.Gameplay.P1RotateLeft.canceled -= OnP1RotateLeft;

        controls.Gameplay.P1RotateRight.performed -= OnP1RotateRight;
        controls.Gameplay.P1RotateRight.canceled -= OnP1RotateRight;

        controls.Gameplay.P2RotateLeft.performed -= OnP2RotateLeft;
        controls.Gameplay.P2RotateLeft.canceled -= OnP2RotateLeft;

        controls.Gameplay.P2RotateRight.performed -= OnP2RotateRight;
        controls.Gameplay.P2RotateRight.canceled -= OnP2RotateRight;

        controls.Disable();
    }

    private void OnDestroy()
    {
        controls.Dispose();
    }

    private void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    private void OnP1Move(InputAction.CallbackContext context)
    {
        p1MoveInput = context.ReadValue<Vector2>();
    }

    private void OnP2Move(InputAction.CallbackContext context)
    {
        p2MoveInput = context.ReadValue<Vector2>();
    }

    private void OnP1RotateLeft(InputAction.CallbackContext context)
    {
        p1RotateLeftHeld = context.ReadValueAsButton();
    }

    private void OnP1RotateRight(InputAction.CallbackContext context)
    {
        p1RotateRightHeld = context.ReadValueAsButton();
    }

    private void OnP2RotateLeft(InputAction.CallbackContext context)
    {
        p2RotateLeftHeld = context.ReadValueAsButton();
    }

    private void OnP2RotateRight(InputAction.CallbackContext context)
    {
        p2RotateRightHeld = context.ReadValueAsButton();
    }

    private void HandleMovement()
    {
        const float threshold = 0.5f;
        bool moved = false;

        // Both players push right -> move down
        if (p1MoveInput.x > threshold && p2MoveInput.x > threshold)
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
            moved = true;
        }
        // Both players push left -> move up
        else if (p1MoveInput.x < -threshold && p2MoveInput.x < -threshold)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            moved = true;
        }
        // Both players push down -> move left
        else if (p1MoveInput.y < -threshold && p2MoveInput.y < -threshold)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            moved = true;
        }
        // Both players push up -> move right
        else if (p1MoveInput.y > threshold && p2MoveInput.y > threshold)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            moved = true;
        }

        if (moved)
        {
            HandleFootstep(0.5f);
        }
    }

    private void HandleRotation()
    {
        bool rotated = false;

        // Rotation around player one target
        if (p1RotateLeftHeld)
        {
            transform.RotateAround(playerOneTarget.transform.position, Vector3.back, maxTurnSpeed * Time.deltaTime);
            rotated = true;
        }

        if (p1RotateRightHeld)
        {
            transform.RotateAround(playerOneTarget.transform.position, Vector3.forward, maxTurnSpeed * Time.deltaTime);
            rotated = true;
        }

        // Rotation around player two target
        if (p2RotateLeftHeld)
        {
            transform.RotateAround(playerTwoTarget.transform.position, Vector3.back, maxTurnSpeed * Time.deltaTime);
            rotated = true;
        }

        if (p2RotateRightHeld)
        {
            transform.RotateAround(playerTwoTarget.transform.position, Vector3.forward, maxTurnSpeed * Time.deltaTime);
            rotated = true;
        }

        if (rotated)
        {
            HandleFootstep(0.2f);
        }
    }

    private void HandleFootstep(float amount)
    {
        globalVariables.footCounter += amount;

        if (globalVariables.footCounter > 100)
        {
            globalVariables.playSound = true;
            globalVariables.footCounter = 0;
        }

        if (globalVariables.playSound)
        {
            source.Play();
            globalVariables.playSound = false;
        }
    }
}