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

    public void useCrans6()
    {
        PlayerScript.Instance.playerCrans = 6;
    }

    public void useCrans5()
    {
        PlayerScript.Instance.playerCrans = 5;
    }

    public void useCrans4()
    {
        PlayerScript.Instance.playerCrans = 4;
    }
    public void useCrans3()
    {
        PlayerScript.Instance.playerCrans = 3;
    }

    public void useCrans2()
    {
        PlayerScript.Instance.playerCrans = 2;
    }

    public void useCrans1()
    {
        PlayerScript.Instance.playerCrans = 1;
    }
}
