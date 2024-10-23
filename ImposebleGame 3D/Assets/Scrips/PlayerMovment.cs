using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private float jumpInput;
    private Vector3 movedirection;
    [SerializeField] private Rigidbody objRb;
    [SerializeField] private BoxCollider boxCollider;
    [SerializeField] private float jumpForce = 5.0f;
    public float speed;

    void Start()
    {
        objRb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");
        movedirection = new Vector3(0 , objRb.velocity.y ,1 * speed);

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpInput += jumpForce;
        }*/
    }
    void FixedUpdate()
    {
        //if ()
        //objRb.AddForce(new Vector3(0 , jumpInput * jumpForce, 0));


        if (IsGrounded())
        {
            objRb.AddForce(Vector3.up * (jumpInput * jumpForce), ForceMode.Impulse);
        }
        objRb.velocity = movedirection;
    }

    private bool IsGrounded()
    {
        bool raycastHit = Physics.Raycast(boxCollider.bounds.center,Vector3.down, boxCollider.bounds.extents.y + 0.1f, LayerMask.GetMask("Ground"));

        if (raycastHit)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void death()
    {
        SceneManager.LoadScene(0);
    }
}
