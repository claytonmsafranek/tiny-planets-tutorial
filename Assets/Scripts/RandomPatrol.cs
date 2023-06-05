using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatrol : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        // initialize sides of screen
        ScreenUtils.Initialize();
        minX = ScreenUtils.ScreenLeft;
        maxX = ScreenUtils.ScreenRight;
        minY = ScreenUtils.ScreenBottom;
        maxY = ScreenUtils.ScreenTop;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
