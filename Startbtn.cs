using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Startbtn : MonoBehaviour,IPointerClickHandler
{
    public int SceneIndexDestination = 1;

    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();

        if(scene.buildIndex==0)
          SceneManager.LoadScene(SceneIndexDestination);
    }
}
