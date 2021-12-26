using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VikingMove : MonoBehaviour
{
    public float JumpingForce;

    Animator animator;
    Rigidbody rb;
    MeshRenderer mr;
    [SerializeField] float movingSpeed = 10f;
    bool onGround = false;
    bool run = false;
    bool START = false;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        run = false;
        if (Input.GetKey(KeyCode.W))
        {
            START = true;
        }

        if (START==true)
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
            run = true;
            if (Input.GetKey(KeyCode.A))
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left; run = true;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right; run = true;
            }

            if (Input.GetKeyDown(KeyCode.Space) && onGround)
            {
                rb.AddForce(JumpingForce * Vector3.up);
            }


        }




        animator.SetBool("Run", run);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name=="floor"|| collision.transform.name == "bound")
        {
            onGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.transform.name=="floor" || collision.transform.name == "bound")
        {
            onGround = false;
        }
    }







}
