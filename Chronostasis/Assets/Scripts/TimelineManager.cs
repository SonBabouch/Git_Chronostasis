using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    public static TimelineManager Instance;
    public List<EnemiScript> numberOfEnemies = new List<EnemiScript>();
    public Transform[] skillsTimeline = new Transform[7];
    public Transform[] characterTimeline = new Transform[7];
    public Transform baseCran;
    public bool canPlayerMove;
    public bool canEnemiMove;
    public bool canMove;
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

    private void FixedUpdate()
    {
        for (int i = 0; i < numberOfEnemies.Count; i++)
        {
            if(numberOfEnemies[i].enemiCrans != 0 || PlayerScript.Instance.playerCrans != 0)
            {
                PlayerScript.Instance.PlayerMoveOnTimeline();
                numberOfEnemies[i].EnemiMoveOnTimeline();
            }


            if (PlayerScript.Instance.playerIsMoving == false && canPlayerMove == true && canMove == true && PlayerScript.Instance.playerCrans != 0 && numberOfEnemies[i].enemiCrans != 0)
            {
                MakePlayerMove();

            }
            if (numberOfEnemies[i].enemiIsMoving == false && canEnemiMove == true && canMove == true && numberOfEnemies[i].enemiCrans != 0 && PlayerScript.Instance.playerCrans != 0)
            {
                MakeEnemiMove();
            }
        }
    }

    private void Update()
    {
        for (int i = 0; i < numberOfEnemies.Count; i++)
        {
            if (PlayerScript.Instance.playerTransform.transform.position == baseCran.transform.position && PlayerScript.Instance.playerCrans == 0 || numberOfEnemies[i].enemiTransform.transform.position == baseCran.transform.position && numberOfEnemies[i].enemiCrans == 0)
            {
                canMove = false;
            }
            else canMove = true;
        }
       
    }
    public void MakePlayerMove()
    {
        canPlayerMove = false;

        PlayerScript.Instance.playerCrans--;
        canPlayerMove = true;
    }

    public void MakeEnemiMove()
    {
        for (int i = 0; i < numberOfEnemies.Count; i++)
        {
            canEnemiMove = false;

            numberOfEnemies[i].enemiCrans--;
            canEnemiMove = true;
        }
    }
}
