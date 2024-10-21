using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private float jumpInput;
    private Vector3 movedirection;
    [SerializeField] private Rigidbody objRb;
    [SerializeField] private float force = 5.0f;
    [SerializeField] private int maxSpeed = 10;

    void Start()
    {
        objRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");
        movedirection = new Vector3(0 , jumpInput ,1);
    }
    void FixedUpdate()
    {
        //if ()
        objRb.AddForce(movedirection * force);
    }
}
