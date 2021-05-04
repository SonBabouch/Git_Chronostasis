﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    public static TimelineManager Instance;
    public Transform[] skillsTimeline = new Transform[7];
    public Transform[] characterTimeline = new Transform[7];
    public Transform baseCran;
    public bool canPlayerMove;
    public bool canMoveOnTimeline;
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
        if (PlayerScript.Instance.playerCrans <= 0)
        {
            canMoveOnTimeline = false;
        }
        else canMoveOnTimeline = true;


        if (canPlayerMove && canMoveOnTimeline)
        {
            StartCoroutine(MakePlayerMove());
        }

    }
    public IEnumerator MakePlayerMove()
    {
        canPlayerMove = false;
        yield return new WaitForSeconds(1f);
        PlayerScript.Instance.playerCrans--;
        canPlayerMove = true;
    }

    //public IEnumerator CombatTimer()
    //{
    //    takingTimeAway = true;
    //    yield return new WaitForSeconds(1);
    //    Enemy.Instance.health -= 0.5f;
    //    secondsLeft -= 1;
    //    takingTimeAway = false;
    //}
}
