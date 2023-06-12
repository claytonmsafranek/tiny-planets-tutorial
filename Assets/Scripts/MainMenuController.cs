using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get the rect transform position of the title text
        Vector3 titlePos = gameObject.GetComponent<RectTransform>().anchoredPosition3D;
        Debug.Log("Title position: " + titlePos);
    }
}
