using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAnim : MonoBehaviour
{
    private Animator anim;
    private TrailRenderer trail;
    public bool attackPossible;
    public float startTime;
    public float waitTime;

    void Start()
    {
        anim = GetComponent<Animator>();
        trail = GetComponent<TrailRenderer>();
        waitTime = startTime;
        attackPossible = true;
    }

    void Update()
    {
        if(attackPossible == false && waitTime > 0)
        {
            waitTime -= Time.deltaTime;
            trail.enabled = true;
        }
        else
        {
            trail.enabled = false;
            attackPossible = true;
            waitTime = startTime;
        }
        if (attackPossible == true && Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("isAttack", true);
            attackPossible = false;
        }
        else if(attackPossible == true)
        {
            anim.SetBool("isAttack", false);
        }
    }
}
