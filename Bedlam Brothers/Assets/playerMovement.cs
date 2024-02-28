using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 1;
    public GameObject playerOneTarget;
    public GameObject playerTwoTarget;
    public Transform objectToLookAt;
    public float maxTurnSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + (Vector3.up * moveSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        }
        // Rotation Player 1 target
        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(playerOneTarget.transform.position, Vector3.back, 20 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.RotateAround(playerOneTarget.transform.position, Vector3.forward, 20 * Time.deltaTime);
        }
        // Rotation Player 2 target
        if (Input.GetKey(KeyCode.Y))
        {
            transform.RotateAround(playerTwoTarget.transform.position, Vector3.back, 20 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.I))
        {
            transform.RotateAround(playerTwoTarget.transform.position, Vector3.forward, 20 * Time.deltaTime);
        }
    }
}
