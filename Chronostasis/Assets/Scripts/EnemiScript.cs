using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiScript : MonoBehaviour
{
    public Transform enemiTransform;
    public int enemiCrans = 0;
    public float speed;
    public bool enemyIsMoving;


    private void Start()
    {
        enemiTransform.transform.position = TimelineManager.Instance.baseCran.transform.position;
    }

    private void FixedUpdate()
    {
        LimitEnemiCrans();
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
        enemyIsMoving = true;
        if (enemiTransform.transform.position != TimelineManager.Instance.characterTimeline[index].transform.position)
        {
            enemiTransform.transform.position = Vector3.MoveTowards(enemiTransform.transform.position, TimelineManager.Instance.characterTimeline[index].transform.position, speed * Time.deltaTime);
        }
        else if (enemiTransform.transform.position == TimelineManager.Instance.characterTimeline[index].transform.position)
        {
            enemyIsMoving = false;
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

        //if (playerCrans == 0)
        //{
        //    isMoving = false;
        //}
    }

}
