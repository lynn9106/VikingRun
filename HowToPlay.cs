using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class HowToPlay : MonoBehaviour, IPointerClickHandler
{
 

    public void OnPointerClick(PointerEventData e)
    {

        SceneManager.LoadScene(3);
    }
}
