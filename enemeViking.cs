using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemeViking : MonoBehaviour
{
    public GameObject viking;

    void Update()
    {
        transform.position = viking.transform.position + (-3) * viking.transform.forward;
    }





}
