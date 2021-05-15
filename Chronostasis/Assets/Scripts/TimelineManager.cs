using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    public static TimelineManager Instance;
    public List<EnemiScript> numberOfEnemies = new List<EnemiScript>();
    public List<SkillScript> numberOfSkills = new List<SkillScript>();
    public Transform[] skillsTimeline = new Transform[7];
    public Transform[] characterTimeline = new Transform[7];
    public Transform baseCran;
    public bool canPlayerMove;
    public bool canEnemiMove;
    public bool canSkillMove;
    public bool canMove;

    public GameObject skill;
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
                numberOfSkills[i].SkillMoveOnTimeline();
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
            if (PlayerScript.Instance.playerCranEnum == PlayerScript.PlayerCranEnum.baseCran || numberOfEnemies[i].enemiCranEnum == EnemiScript.EnemiCranEnum.baseCran || numberOfSkills[i].skillCranEnum == SkillScript.SkillCranEnum.baseCran)
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
            canSkillMove = false;

            PlayerScript.Instance.playerCrans--;
            numberOfEnemies[i].enemiCrans--;
            numberOfSkills[i].skillCran--;


            canPlayerMove = true;
            canEnemiMove = true;
            canSkillMove = true;
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
                numberOfSkills[i].skillCran = 0;

                PlayerScript.Instance.playerTransform.transform.position = Vector3.MoveTowards(PlayerScript.Instance.playerTransform.transform.position, baseCran.transform.position, PlayerScript.Instance.speed * Time.deltaTime);
                numberOfEnemies[i].enemiTransform.transform.position = Vector3.MoveTowards(numberOfEnemies[i].enemiTransform.transform.position, baseCran.transform.position, numberOfEnemies[i].speed * Time.deltaTime);
                numberOfSkills[i].skillTransform.transform.position = Vector3.MoveTowards(numberOfSkills[i].skillTransform.transform.position, baseCran.transform.position, numberOfEnemies[i].speed * Time.deltaTime);
            }
        }
    }

    public void SpawnSkillCran1()
    {
        numberOfSkills.Add(skill.GetComponent<SkillScript>());
        Instantiate(skill, skillsTimeline[1].transform.position, Quaternion.identity);
    }

}
