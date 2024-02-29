using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMatress : MonoBehaviour
{
    public GameObject Target;
    public int speed;
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,Target.transform.position, speed * Time.deltaTime);
    }
}
