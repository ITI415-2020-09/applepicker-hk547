using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 1f; //speed that appletree moves
    public float leftAndRightEdge = 10f; // distance where appletree turns around
    public float chanceToChangeDirections = 0.1f; // chance that tree change directions
    public float secondsBetweenAppleDrops = 1f; // rate at which apples will be instantiated

    // Start is called before the first frame update
    void Start()
    {
     // dropping apples every second
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement 
        // current position of appletree
        // time based not frame
        // move to new position
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // change Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // move left
        }
        else if (Random.value < chanceToChangeDirections) // change direction
        {
            speed *= -1; //
        }
    }
}
