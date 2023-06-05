using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatrol : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float speed;

    Vector2 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        // initialize sides of screen
        ScreenUtils.Initialize();
        minX = ScreenUtils.ScreenLeft;
        maxX = ScreenUtils.ScreenRight;
        minY = ScreenUtils.ScreenBottom;
        maxY = ScreenUtils.ScreenTop;

        // define target for planets to move to
        targetPosition = GetRandomPosition();

    }

    // Update is called once per frame
    void Update()
    {
        // check if planet position is equal to target position, need to cast transform to vector2 from vector3
        if ((Vector2)transform.position != targetPosition)
        {
            // MoveTowards takes in current position, target postion, and speed to move
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            // calcualte a new target position
            targetPosition = GetRandomPosition();
        }
        
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }
}
