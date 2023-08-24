using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Target;

    Vector3 Pos = new Vector3(0f, 0f,-10f);
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
       
    }

    public void CamFollow()
    {
        
            Pos = Vector2.Lerp(transform.position, Target.transform.position, 0.1f);
            transform.position = new Vector3(Pos.x, Pos.y, -10);
            Debug.Log(Pos.x);

        
    }
}
