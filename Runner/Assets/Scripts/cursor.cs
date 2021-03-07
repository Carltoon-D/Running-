using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    Transform scope;
    Vector3 mouseposition;
    // Start is called before the first frame update
    void Start()
    {
        scope = GetComponent<Transform>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Setting up the mouse position to connect to the cursor
        mouseposition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        mouseposition.z = 0;
        scope.position = mouseposition;

    }
}
