using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private float PosX;
    private Vector3 playerPos;

    public float Speed = 1f;
    public float ClampLeft = -6f;
    public float ClampRight = 6f;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerPos = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        PosX = transform.position.x + (Input.GetAxis("Horizontal") * Speed);
        PosX = Mathf.Clamp(PosX, ClampLeft, ClampRight);
        playerPos = new Vector3(PosX, playerPos.y, playerPos.z);
        transform.position = playerPos;
    }
}