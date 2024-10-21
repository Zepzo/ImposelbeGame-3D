using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float jumpInput;
    private Vector3 movedirection;
    private Rigidbody objRb;
    public float speed ;

    void Start()
    {
        objRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");
        movedirection = new Vector3(horizontalInput , jumpInput ,verticalInput);
    }
    void FixedUpdate()
    {
        objRb.velocity = movedirection * speed;
    }
}
