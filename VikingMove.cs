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
    bool canTurnR = false;
    Quaternion target;




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
        Move();
        Rotate();

        animator.SetBool("Run", run);
    }


    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            START = true;
        }

        if (START == true)
        {
            transform.localPosition += movingSpeed * Time.deltaTime * transform.forward;
            run = true;
            if (Input.GetKey(KeyCode.A))
            {
                transform.localPosition += movingSpeed * Time.deltaTime * (-transform.right); run = true;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (canTurnR)
                {
                    target = Quaternion.LookRotation(transform.right);
                    canTurnR = false;
                }
                else
                    transform.localPosition += movingSpeed * Time.deltaTime * transform.right; run = true;
            }

            if (Input.GetKeyDown(KeyCode.Space) && onGround)
            {
                rb.AddForce(JumpingForce * transform.up);
            }
        }//Start

    }//move

    void Rotate()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, 500 * Time.deltaTime);
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


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "cornerTurnR")
        {
            canTurnR = true;
        }
    }



    private void OnTriggerExite(Collider other)
    {
        if (other.transform.name == "cornerTurnR")
        {
            canTurnR = false;
        }
    }






}
