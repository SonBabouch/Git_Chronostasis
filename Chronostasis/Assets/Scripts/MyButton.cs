using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

public class MyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Button button;
    public bool isPressed;
    public bool isOnButton;

    public  void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isOnButton = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOnButton = false;
    }

    public  void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

}
