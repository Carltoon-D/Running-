using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{// the ray casting is to set up the cursor to hit the moving target
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    Transform scope;
    public AnimationCurve lerpCurve;
    float move;
    // Start is called before the first frame update
    void Start()
    {
        scope = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {//setting up the target to move left to right 
        move += 0.2F * Time.deltaTime;
        float time1 = Mathf.Lerp(-5, 5, lerpCurve.Evaluate(move));
        Vector3 place = new Vector3(time1, 0);
        scope.position = place;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Target")
            {
                Debug.Log("This is a Player");
            }
           
        }
    }
}
