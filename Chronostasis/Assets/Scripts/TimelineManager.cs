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
            if (numberOfEnemies[i].enemiCrans != 0 || PlayerScript.Instance.playerCrans != 0)
            {
                PlayerScript.Instance.PlayerMoveOnTimeline();
                numberOfEnemies[i].EnemiMoveOnTimeline();
            }


            if (numberOfEnemies[i].enemiIsMoving == false && canEnemiMove == true && canMove == true && numberOfEnemies[i].enemiCranEnum != EnemiScript.EnemiCranEnum.baseCran && PlayerScript.Instance.playerCranEnum != PlayerScript.PlayerCranEnum.baseCran && PlayerScript.Instance.playerIsMoving == false && canPlayerMove == true)
            { 
                MakeElementsMove();
            }
        }
    }

    private void Update()
    {
        for (int i = 0; i < numberOfEnemies.Count; i++)
        {
            if (PlayerScript.Instance.playerCranEnum == PlayerScript.PlayerCranEnum.baseCran || numberOfEnemies[i].enemiCranEnum == EnemiScript.EnemiCranEnum.baseCran)
            {
                canMove = false;
            }
            else canMove = true;
        }

        FixFirstCran();
    }

    public void MakeElementsMove()
    {
        for (int i = 0; i < numberOfEnemies.Count; i++)
        {
            canEnemiMove = false;
            canPlayerMove = false;

            PlayerScript.Instance.playerCrans--;
            numberOfEnemies[i].enemiCrans--;

            canPlayerMove = true;
            canEnemiMove = true;
        }
    }

    public void FixFirstCran()
    {
        for (int i = 0; i < numberOfEnemies.Count; i++)
        {
            if (PlayerScript.Instance.playerCranEnum == PlayerScript.PlayerCranEnum.firstCran && numberOfEnemies[i].enemiCranEnum == EnemiScript.EnemiCranEnum.firstCran)
            {
                PlayerScript.Instance.playerCrans = 0;
                numberOfEnemies[i].enemiCrans = 0;

                PlayerScript.Instance.playerTransform.transform.position = Vector3.MoveTowards(PlayerScript.Instance.playerTransform.transform.position, baseCran.transform.position, PlayerScript.Instance.speed * Time.deltaTime);
                numberOfEnemies[i].enemiTransform.transform.position = Vector3.MoveTowards(numberOfEnemies[i].enemiTransform.transform.position, baseCran.transform.position, numberOfEnemies[i].speed * Time.deltaTime);
            }
        }

    }
}
