using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;



public class playerMovement : MonoBehaviour
{
    public ControllerSupport playerControls;
    public AudioSource source;
    public float moveSpeed = 1;
    public GameObject playerOneTarget;
    public GameObject playerTwoTarget;
    public Transform objectToLookAt;
    public float maxTurnSpeed = 50;

    private InputAction p1Right;
    private InputAction p1Left;
    private InputAction p1Up;
    private InputAction p1Down;
    private InputAction p1RotateLeft;
    private InputAction p1RotateRight;
    private InputAction p2Right;
    private InputAction p2Left;
    private InputAction p2Up;
    private InputAction p2Down;
    private InputAction p2RotateLeft;
    private InputAction p2RotateRight;



    public void Awake()
    {
        playerControls = new ControllerSupport();
    }

    private void OnEnable()
    {
        p1Right = playerControls.Gameplay.P1Right;
        p1Right.Enable();
        p1Left = playerControls.Gameplay.P1Left;
        p1Left.Enable();
        p1Up = playerControls.Gameplay.P1Up;
        p1Up.Enable();
        p1Down = playerControls.Gameplay.P1Down;
        p1Down.Enable();
        p1RotateLeft = playerControls.Gameplay.P1RotateLeft;
        p1RotateLeft.Enable();
        p1RotateRight = playerControls.Gameplay.P1RotateRight;
        p1RotateRight.Enable();
        p2Right = playerControls.Gameplay.P2Right;
        p2Right.Enable();
        p2Left = playerControls.Gameplay.P2Left;
        p2Left.Enable();
        p2Up = playerControls.Gameplay.P2Up;
        p2Up.Enable();
        p2Down = playerControls.Gameplay.P2Down;
        p2Down.Enable();
        p2RotateLeft = playerControls.Gameplay.P2RotateLeft;
        p2RotateLeft.Enable();
        p2RotateRight = playerControls.Gameplay.P2RotateRight;
        p2RotateRight.Enable();

    }
    private void OnDisable()
    {
        p1Right.Disable();
        p1Left.Disable();
        p1Up.Disable();
        p1Down.Disable();
        p1RotateLeft.Disable();
        p1RotateRight.Disable();
        p2Right.Disable();
        p2Left.Disable();
        p2Up.Disable();
        p2Down.Disable();
        p2RotateLeft.Disable();
        p2RotateRight.Disable();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        if (p1Right.ReadValue<float>() > 0 && p2Right.ReadValue<float>() > 0)
        {
            transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
            globalVariables.footCounter = globalVariables.footCounter + 0.5;
            if (globalVariables.footCounter > 100)
            {
                globalVariables.playSound = true;
                globalVariables.footCounter = 0;
            }
            if (globalVariables.playSound == true)
            {
                source.Play();
                globalVariables.playSound = false;
            }
        }
        if (p1Left.ReadValue<float>() > 0 && p2Left.ReadValue<float>() > 0)
        {
            transform.position = transform.position + (Vector3.up * moveSpeed) * Time.deltaTime;
            globalVariables.footCounter = globalVariables.footCounter + 0.5;
            if (globalVariables.footCounter > 100)
            {
                globalVariables.playSound = true;
                globalVariables.footCounter = 0;
            }
            if (globalVariables.playSound == true)
            {
                source.Play();
                globalVariables.playSound = false;
            }
        }
        if (p1Down.ReadValue<float>() > 0 && p2Down.ReadValue<float>() > 0)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
            globalVariables.footCounter = globalVariables.footCounter + 0.5;
            if (globalVariables.footCounter > 100)
            {
                globalVariables.playSound = true;
                globalVariables.footCounter = 0;
            }
            if (globalVariables.playSound == true)
            {
                source.Play();
                globalVariables.playSound = false;
            }
        }
        if (p1Up.ReadValue<float>() > 0 && p2Up.ReadValue<float>() > 0)
        {
            transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
            globalVariables.footCounter = globalVariables.footCounter + 0.5;
            if (globalVariables.footCounter > 100)
            {
                globalVariables.playSound = true;
                globalVariables.footCounter = 0;
            }
            if (globalVariables.playSound == true)
            {
                source.Play();
                globalVariables.playSound = false;
            }
        }
        // Rotation Player 1 target
        if (p1RotateLeft.IsPressed())
        {
            transform.RotateAround(playerOneTarget.transform.position, Vector3.back, maxTurnSpeed * Time.deltaTime);
            globalVariables.footCounter = globalVariables.footCounter + 0.2;
            if (globalVariables.footCounter > 100)
            {
                globalVariables.playSound = true;
                globalVariables.footCounter = 0;
            }
            if (globalVariables.playSound == true)
            {
                source.Play();
                globalVariables.playSound = false;
            }
        }
        if (p1RotateRight.IsPressed())
        {
            transform.RotateAround(playerOneTarget.transform.position, Vector3.forward, maxTurnSpeed * Time.deltaTime);
            globalVariables.footCounter = globalVariables.footCounter + 0.2;
            if (globalVariables.footCounter > 100)
            {
                globalVariables.playSound = true;
                globalVariables.footCounter = 0;
            }
            if (globalVariables.playSound == true)
            {
                source.Play();
                globalVariables.playSound = false;
            }
        }
        // Rotation Player 2 target
        if (p2RotateLeft.IsPressed())
        {
            transform.RotateAround(playerTwoTarget.transform.position, Vector3.back, maxTurnSpeed * Time.deltaTime);
            globalVariables.footCounter = globalVariables.footCounter + 0.2;
            if (globalVariables.footCounter > 100)
            {
                globalVariables.playSound = true;
                globalVariables.footCounter = 0;
            }
            if (globalVariables.playSound == true)
            {
                source.Play();
                globalVariables.playSound = false;
            }
        }
        if (p2RotateRight.IsPressed())
        {
            transform.RotateAround(playerTwoTarget.transform.position, Vector3.forward, maxTurnSpeed * Time.deltaTime);
            globalVariables.footCounter = globalVariables.footCounter + 0.2;
            if (globalVariables.footCounter > 100)
            {
                globalVariables.playSound = true;
                globalVariables.footCounter = 0;
            }
            if (globalVariables.playSound == true)
            {
                source.Play();
                globalVariables.playSound = false;
            }
        }
        //source.Stop();
    }

    static void playSoundFunction()
    {


    }
}
