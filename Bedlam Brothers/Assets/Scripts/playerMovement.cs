using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;



public class playerMovement : MonoBehaviour
{
    public InputAction playerControls;
    public float moveSpeed = 1;
    public GameObject playerOneTarget;
    public GameObject playerTwoTarget;
    public Transform objectToLookAt;
    public float maxTurnSpeed = 50;

    private void OnEnable()
    {
        playerControls.Enable();

    }
    private void OnDisable()
    {
        playerControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + (Vector3.up * moveSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        }
        // Rotation Player 1 target
        if (Input.GetKey(KeyCode.Z))
        {
            transform.RotateAround(playerOneTarget.transform.position, Vector3.back, maxTurnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.RotateAround(playerOneTarget.transform.position, Vector3.forward, maxTurnSpeed * Time.deltaTime);
        }
        // Rotation Player 2 target
        if (Input.GetKey(KeyCode.I))
        {
            transform.RotateAround(playerTwoTarget.transform.position, Vector3.back, maxTurnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(playerTwoTarget.transform.position, Vector3.forward, maxTurnSpeed * Time.deltaTime);
        }
    }
}
