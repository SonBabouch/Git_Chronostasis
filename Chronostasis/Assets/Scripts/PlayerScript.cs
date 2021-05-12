using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static PlayerScript Instance;
    public Transform playerTransform;
    public int playerCrans = 0;
    public float speed;
    public bool playerIsMoving;

    public enum PlayerCranEnum {baseCran, firstCran, secondCran, thirdCran, fourthCran, fifthCran, sixthCran}
    public PlayerCranEnum playerCranEnum;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


    }
    private void Start()
    {
        playerTransform.transform.position = TimelineManager.Instance.baseCran.transform.position;
    }

    private void FixedUpdate()
    {
        LimitPlayerCrans();
        PlayerSwitchEnum();
    }

    public void PlayerMoveOnTimeline()
    {
            switch (playerCrans)
            {
                case 0:
                    playerMove(playerCrans);
                    break;
                case 1:
                    playerMove(playerCrans);
                    break;
                case 2:
                    playerMove(playerCrans);
                    break;
                case 3:
                    playerMove(playerCrans);
                    break;
                case 4:
                    playerMove(playerCrans);
                    break;
                case 5:
                    playerMove(playerCrans);
                    break;
                case 6:
                    playerMove(playerCrans);
                    break;
                default:
                    break;
            }
    }

    public void playerMove(int index)
    {

        if (playerTransform.transform.position != TimelineManager.Instance.characterTimeline[index].transform.position)
        {
            playerIsMoving = true;
            playerTransform.transform.position = Vector3.MoveTowards(playerTransform.transform.position, TimelineManager.Instance.characterTimeline[index].transform.position, speed * Time.deltaTime);
        }
        else if (playerTransform.transform.position == TimelineManager.Instance.characterTimeline[index].transform.position)
        {
            playerIsMoving = false;
        }
    }


    public void LimitPlayerCrans()
    {
        if(playerCrans > 6)
        {
            playerCrans = 6;
        }
        else if(playerCrans < 0)
        {
            playerCrans = 0;
        }

        if (playerCrans == 0)
        {
            playerIsMoving = false;
        }
    }

    public void PlayerSwitchEnum()
    {
        if(playerTransform.transform.position == TimelineManager.Instance.characterTimeline[0].transform.position)
        {
            playerCranEnum = PlayerCranEnum.baseCran;
        }
        else if(playerTransform.transform.position == TimelineManager.Instance.characterTimeline[1].transform.position)
        {
            playerCranEnum = PlayerCranEnum.firstCran;
        }
        else if(playerTransform.transform.position == TimelineManager.Instance.characterTimeline[2].transform.position)
        {
            playerCranEnum = PlayerCranEnum.secondCran;
        }
        else if(playerTransform.transform.position == TimelineManager.Instance.characterTimeline[3].transform.position)
        {
            playerCranEnum = PlayerCranEnum.thirdCran;
        }
        else if(playerTransform.transform.position == TimelineManager.Instance.characterTimeline[4].transform.position)
        {
            playerCranEnum = PlayerCranEnum.fourthCran;
        }
        else if(playerTransform.transform.position == TimelineManager.Instance.characterTimeline[5].transform.position)
        {
            playerCranEnum = PlayerCranEnum.fifthCran;
        }
        else if(playerTransform.transform.position == TimelineManager.Instance.characterTimeline[6].transform.position)
        {
            playerCranEnum = PlayerCranEnum.sixthCran;
        }
    }
}
