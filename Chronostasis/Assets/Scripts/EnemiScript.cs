using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiScript : MonoBehaviour
{
    public Transform enemiTransform;
    public int enemiCrans = 0;
    public int enemiIsOnCrans = 0;
    public float speed;
    public bool enemiIsMoving;
    public enum EnemiCranEnum { baseCran, firstCran, secondCran, thirdCran, fourthCran, fifthCran, sixthCran }
    public EnemiCranEnum enemiCranEnum;

    private void Start()
    {
        enemiTransform.transform.position = TimelineManager.Instance.baseCran.transform.position;
    }

    private void FixedUpdate()
    {
        LimitEnemiCrans();
    }

    //public void EnemiMoveOnTimeline()
    //{
    //    switch (enemiCrans)
    //    {
    //        case 0:
    //            EnemiMove(enemiCrans);
    //            break;
    //        case 1:
    //            EnemiMove(enemiCrans);
    //            break;
    //        case 2:
    //            EnemiMove(enemiCrans);
    //            break;
    //        case 3:
    //            EnemiMove(enemiCrans);
    //            break;
    //        case 4:
    //            EnemiMove(enemiCrans);
    //            break;
    //        case 5:
    //            EnemiMove(enemiCrans);
    //            break;
    //        case 6:
    //            EnemiMove(enemiCrans);
    //            break;
    //        default:
    //            break;
    //    }
    //}
    //public void EnemiMove(int index)
    //{
    //    if (enemiTransform.transform.position != TimelineManager.Instance.characterTimeline[index].transform.position)
    //    {
    //        enemiIsMoving = true;
    //        enemiTransform.transform.position = Vector3.MoveTowards(enemiTransform.transform.position, TimelineManager.Instance.characterTimeline[index].transform.position, speed * Time.deltaTime);
    //    }
    //    else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[index].transform.position)
    //    {
    //        enemiIsMoving = false;
    //    }
    //}
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

    public void EnemiPositionBools()
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
}
