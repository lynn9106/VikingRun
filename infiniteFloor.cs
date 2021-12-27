using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteFloor : MonoBehaviour
{
    public Collider bound;
    int floordecide = 0;





    public GameObject cornerR;
    public GameObject cornerL;

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
 
        if (other.transform.name == "viking") 
        {
            Copy();
        }
    }


    void Copy()
    {
           floordecide = Random.Range(0, 3);
 
           
           float length;
           Vector3 pos;
           Quaternion rot;


          if (floordecide == 0)
           {
                   length = bound.bounds.extents.z * 2;
                   pos = transform.position + length * transform.forward;
                   Instantiate(gameObject, pos, transform.rotation);
   




        }
           else if (floordecide == 1)
           {
               length = bound.bounds.extents.x*2+bound.bounds.extents.z+ bound.bounds.extents.z / 3;
               pos = transform.position + length * transform.forward;
               Instantiate(cornerR, pos, transform.rotation);

               rot = Quaternion.LookRotation(transform.right);
               length =bound.bounds.extents.z;

               pos = pos + length * transform.right;
               Instantiate(gameObject,pos, rot);

        }
           else
           {
               length = bound.bounds.extents.x*3 + bound.bounds.extents.z;
               pos = transform.position + length * transform.forward;
               Instantiate(cornerL, pos, transform.rotation);

               rot = Quaternion.LookRotation(transform.right*(-1));
               length =bound.bounds.extents.z;

               pos = pos + length * transform.right*(-1);
               Instantiate(gameObject, pos,rot);
        } 


        Invoke("WaitAndDestroy", 7f);
    }

    void WaitAndDestroy()
    {
        Destroy(gameObject);
    }







}
