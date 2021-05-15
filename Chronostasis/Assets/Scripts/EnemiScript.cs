using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiScript : MonoBehaviour
{
    public Transform enemiTransform;
    public int enemiCrans = 0;
    public float speed;
    public bool enemiIsMoving;

    public Text enemiHealthText;

    public float enemiHealth = 100f;
    public float enemiMaxHealth = 100f;
    public float enemiMinHealth = 0f;
    public enum EnemiCranEnum { baseCran, firstCran, secondCran, thirdCran, fourthCran, fifthCran, sixthCran }
    public EnemiCranEnum enemiCranEnum;

    private void Start()
    {
        enemiTransform.transform.position = TimelineManager.Instance.baseCran.transform.position;
    }

    private void FixedUpdate()
    {
        LimitEnemiCrans();
        EnemiSwitchEnum();

        if (enemiHealthText != null)
        {
            enemiHealthText.text = "Enemi Health : " + enemiHealth.ToString();
        }
    }

    public void EnemiMoveOnTimeline()
    {
            switch (enemiCrans)
            {
                case 0:
                    EnemiMove(enemiCrans);
                    break;
                case 1:
                    EnemiMove(enemiCrans);
                    break;
                case 2:
                    EnemiMove(enemiCrans);
                    break;
                case 3:
                    EnemiMove(enemiCrans);
                    break;
                case 4:
                    EnemiMove(enemiCrans);
                    break;
                case 5:
                    EnemiMove(enemiCrans);
                    break;
                case 6:
                    EnemiMove(enemiCrans);
                    break;
                default:
                    break;
            }
    }
    public void EnemiMove(int index)
    {
        if (enemiTransform.transform.position != TimelineManager.Instance.characterTimeline[index].transform.position)
        {
            enemiIsMoving = true;
            enemiTransform.transform.position = Vector3.MoveTowards(enemiTransform.transform.position, TimelineManager.Instance.characterTimeline[index].transform.position, speed * Time.deltaTime);
        }
        else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[index].transform.position)
        {
            enemiIsMoving = false;
        }
    }
    public void LimitEnemiCrans()
    {
        if (enemiCrans > 6)
        {
            enemiCrans = 6;
        }
        else if (enemiCrans < 0)
        {
            enemiCrans = 0;
        }

        if (enemiCrans == 0)
        {
            enemiIsMoving = false;
        }
    }

    public void EnemiSwitchEnum()
    {
        if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[0].transform.position)
        {
            enemiCranEnum = EnemiCranEnum.baseCran;
        }
        else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[1].transform.position)
        {
            enemiCranEnum = EnemiCranEnum.firstCran;
        }
        else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[2].transform.position)
        {
            enemiCranEnum = EnemiCranEnum.secondCran;
        }
        else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[3].transform.position)
        {
            enemiCranEnum = EnemiCranEnum.thirdCran;
        }
        else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[4].transform.position)
        {
            enemiCranEnum = EnemiCranEnum.fourthCran;
        }
        else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[5].transform.position)
        {
            enemiCranEnum = EnemiCranEnum.fifthCran;
        }
        else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[6].transform.position)
        {
            enemiCranEnum = EnemiCranEnum.sixthCran;
        }
    }

    public void EnemiMoveCran1()
    {
            enemiCrans = 1;
    }

    public void EnemiMoveCran2()
    {
        enemiCrans = 2;
    }

    public void EnemiMoveCran3()
    {
        enemiCrans = 3;
    }

    public void EnemiMoveCran4()
    {
        enemiCrans = 4;
    }

    public void EnemiMoveCran5()
    {
        enemiCrans = 5;
    }

    public void EnemiMoveCran6()
    {
        enemiCrans = 6;
    }
}
