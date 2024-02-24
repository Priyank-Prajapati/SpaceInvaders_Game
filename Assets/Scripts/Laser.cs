using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.velocity = new Vector2(0, speed);
    }
}
