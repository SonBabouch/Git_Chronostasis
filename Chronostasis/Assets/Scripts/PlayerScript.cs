using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static PlayerScript Instance;
    public Transform playerTransform;
    public int playerCrans = 0;
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

        playerTransform.transform.position = TimelineManager.Instance.baseCran.transform.position;
    }

    private void Update()
    {
        playerMoveOnTimeline();
    }

    public void playerMoveOnTimeline()
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
        }
    }

    public void playerMove(int index)
    {
        playerTransform.transform.position = TimelineManager.Instance.characterTimeline[index].transform.position;
    }


}
