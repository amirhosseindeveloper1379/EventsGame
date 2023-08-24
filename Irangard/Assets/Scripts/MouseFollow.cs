using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public Vector3 MousePos;
    public float MoveSpeed;
    Rigidbody2D Rigidbody;
    Vector2 Pos=new Vector2 (0f,0f);
    CameraFollow cameraFollow;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 0, 0);
        cameraFollow=FindObjectOfType<CameraFollow>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePos = Input.mousePosition;
            MousePos = Camera.main.ScreenToWorldPoint(MousePos);
        }
            
            Pos = Vector2.Lerp(transform.position, MousePos, MoveSpeed);
        
        
    }

    private void FixedUpdate()
    {

        Rigidbody.MovePosition(Pos);
        cameraFollow.CamFollow();
        
    }
}
