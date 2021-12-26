using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Exitbtn : MonoBehaviour,IPointerClickHandler
{

    public void OnPointerClick(PointerEventData e)
    {
        Application.Quit();
    }

}
