using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteFloor : MonoBehaviour
{
    public Collider bound;

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "myViking") ;
        {
            Copy();
        }
    }



    void Copy()
    {
        float length = bound.bounds.extents.z*2;
        Vector3 pos=transform.position+ length*Vector3.forward;
        Instantiate(gameObject , pos , transform.rotation);
        Invoke("WaitAndDestroy", 3f);
    }

    void WaitAndDestroy()
    {
        Destroy(gameObject);

    }







}
