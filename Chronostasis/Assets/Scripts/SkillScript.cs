using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillScript : MonoBehaviour
{
    public Transform skillTransform;
    public int skillCran = 0;
    public float speed;
    public bool skillIsMoving;
    public enum SkillCranEnum { baseCran, firstCran, secondCran, thirdCran, fourthCran, fifthCran, sixthCran }
    public SkillCranEnum skillCranEnum;


    private void FixedUpdate()
    {
        LimitSkillCrans();
        SkillSwitchEnum();
        SkillMoveOnTimeline();
        //if(TimelineManager.Instance.canMove == true)
        //{
        //    TimelineManager.Instance.MakeSkillMove();
        //}

    }

    public void SkillMoveOnTimeline()
    {
        switch (skillCran)
        {
            case 0:
                SkillMove(skillCran);
                break;
            case 1:
                SkillMove(skillCran);
                break;
            case 2:
                SkillMove(skillCran);
                break;
            case 3:
                SkillMove(skillCran);
                break;
            case 4:
                SkillMove(skillCran);
                break;
            case 5:
                SkillMove(skillCran);
                break;
            case 6:
                SkillMove(skillCran);
                break;
            default:
                break;
        }
    }
    public void SkillMove(int index)
    {
        if (skillTransform.transform.position != TimelineManager.Instance.skillsTimeline[index].transform.position)
        {
            skillIsMoving = true;
            skillTransform.transform.position = Vector3.MoveTowards(skillTransform.transform.position, TimelineManager.Instance.skillsTimeline[index].transform.position, speed * Time.deltaTime);
        }
        else if (skillTransform.transform.position == TimelineManager.Instance.skillsTimeline[index].transform.position)
        {
            skillIsMoving = false;
        }
    }
    public void LimitSkillCrans()
    {
        if (skillCran > 6)
        {
            skillCran = 6;
        }
        else if (skillCran < 0)
        {
            skillCran = 0;
        }

        if (skillCran == 0)
        {
            skillIsMoving = false;
        }
    }

    public void SkillSwitchEnum()
    {
        if (skillTransform.transform.position == TimelineManager.Instance.skillsTimeline[0].transform.position)
        {
            skillCranEnum = SkillCranEnum.baseCran;
        }
        else if (skillTransform.transform.position == TimelineManager.Instance.skillsTimeline[1].transform.position)
        {
            skillCranEnum = SkillCranEnum.firstCran;
        }
        else if (skillTransform.transform.position == TimelineManager.Instance.skillsTimeline[2].transform.position)
        {
            skillCranEnum = SkillCranEnum.secondCran;
        }
        else if (skillTransform.transform.position == TimelineManager.Instance.skillsTimeline[3].transform.position)
        {
            skillCranEnum = SkillCranEnum.thirdCran;
        }
        else if (skillTransform.transform.position == TimelineManager.Instance.skillsTimeline[4].transform.position)
        {
            skillCranEnum = SkillCranEnum.fourthCran;
        }
        else if (skillTransform.transform.position == TimelineManager.Instance.skillsTimeline[5].transform.position)
        {
            skillCranEnum = SkillCranEnum.fifthCran;
        }
        else if (skillTransform.transform.position == TimelineManager.Instance.skillsTimeline[6].transform.position)
        {
            skillCranEnum = SkillCranEnum.sixthCran;
        }
    }

    //Demain faire en sorte que le skills bouge et lorsqu'il que skill cran = 0 regarder si il y a un ennemi ou un joueur si il y a un des 2 faire des dégats
}
