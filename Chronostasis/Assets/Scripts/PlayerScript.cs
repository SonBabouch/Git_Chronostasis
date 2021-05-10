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
    }

    public void PlayerMoveOnTimeline()
    {
        switch(playerCrans)
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
        playerIsMoving = true;
        if (playerTransform.transform.position != TimelineManager.Instance.characterTimeline[index].transform.position)
        {
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
}
