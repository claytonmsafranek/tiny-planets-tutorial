using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    bool moveAllowed;
    Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // check if there is a finger touching the screen
        // touchCount is 1 if 1 finger, 2 if 2 fingers, etc
        if (Input.touchCount > 0)
        {
            // Debug.Log("TOUCHED - " + Input.touchCount);
            // get the first touch (is a list, we get 0 for the first one)
            Touch touch = Input.GetTouch(0);
            // get position of touch, touch.position returns in pixel coords, need it in world space - need to convert
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            // check touch phase
            if (touch.phase == TouchPhase.Began)
            {
                // check if we touched a collider that is linked to a planet
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    Debug.Log("TOUCHED A PLANET");
                    moveAllowed = true;
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                // update position of planet
                if (moveAllowed)
                {
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
                }

            }

            if (touch.phase == TouchPhase.Ended)
            {
                // reset move allowed to false
                moveAllowed = false;
            }
        }
        
    }
}
