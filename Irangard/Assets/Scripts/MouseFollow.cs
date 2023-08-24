using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    Vector3 MousePos;
    public float MoveSpeed;
    Rigidbody2D Rigidbody;
    Vector2 Pos=new Vector2 (0f,0f);
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
    
            MousePos = Input.mousePosition;
            MousePos = Camera.main.ScreenToWorldPoint(MousePos);
            Pos = Vector2.Lerp(transform.position, MousePos, MoveSpeed);
     
    }

    private void FixedUpdate()
    {
        Rigidbody.MovePosition(Pos);
    }
}
