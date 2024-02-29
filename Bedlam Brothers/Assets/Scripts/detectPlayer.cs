using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;
    public Vector2 top_right_corner;
    public Vector2 bottom_left_corner;
    bool player1Hit = false;
    bool player2Hit = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(" hit");
        if (collision.name == "Player 1")
        {
            player1Hit = true;
        }
        if (collision.name == "Player 2")
        {
            player2Hit = true;
        }
        if (player1Hit && player2Hit)
        {
            //SceneManager.LoadScene("Level Complete", LoadSceneMode.Single);
            globalVariables.currentGameCompleted = true;
            SceneManager.LoadScene("Level Complete", LoadSceneMode.Single);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player 1")
        {
            player1Hit = false;
        }
        if (other.name == "Player 2")
        {
            player2Hit = false;
        }
    }

}
