using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float speed;
    public float minX, maxX;
    public GameObject laser;
    public Transform laserSpawn;
    public float fireRateDelay = 0.25f;

    private Rigidbody2D rbody;
    private float timer = 0;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizon = Input.GetAxis("Horizontal");

        rbody.velocity = new Vector2(horizon, 0)* speed;

        rbody.position = new Vector2(Mathf.Clamp(rbody.position.x, minX, maxX), -4);
    }

    void Update()
    { 
        if (Input.GetAxis("Fire1") > 0 && timer > fireRateDelay)
        {
            GameObject gobj = Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            gobj.transform.Rotate(0, 0, 90);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
