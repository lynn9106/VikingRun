using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {
            Invoke("WaitAndDestroy", 7f);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Invoke("WaitAndDestroy", 10f);
        }

    }

    void WaitAndDestroy()
    {
        Destroy(gameObject);
    }





}
