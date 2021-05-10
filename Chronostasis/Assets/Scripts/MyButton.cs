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
        StartCoroutine(Crans6());
    }

    public void useCrans5()
    {
        StartCoroutine(Crans5());
    }

    public void useCrans4()
    {
        StartCoroutine(Crans4());
    }
    public void useCrans3()
    {
        StartCoroutine(Crans3());
    }

    public void useCrans2()
    {
        StartCoroutine(Crans2());
    }

    public void useCrans1()
    {
        StartCoroutine(Crans1());
    }
    public IEnumerator Crans6()
    {
        yield return new WaitForSeconds(0.1f);
        PlayerScript.Instance.playerCrans = 6;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
    }

    public IEnumerator Crans5()
    {
        yield return new WaitForSeconds(0.1f);
        PlayerScript.Instance.playerCrans = 5;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;

    }

    public IEnumerator Crans4()
    {
        yield return new WaitForSeconds(0.1f);
        PlayerScript.Instance.playerCrans = 4;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
    }

    public IEnumerator Crans3()
    {
        yield return new WaitForSeconds(0.1f);
        PlayerScript.Instance.playerCrans = 3;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
    }

    public IEnumerator Crans2()
    {
        yield return new WaitForSeconds(0.1f);
        PlayerScript.Instance.playerCrans = 2;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
    }

    public IEnumerator Crans1()
    {
        yield return new WaitForSeconds(0.1f);
        PlayerScript.Instance.playerCrans = 1;
        //yield return new WaitForSeconds(0.1f);
        //PlayerScript.Instance.playerCrans++;
    }
}
