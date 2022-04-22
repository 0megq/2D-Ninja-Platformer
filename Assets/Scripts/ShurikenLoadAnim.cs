using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenLoadAnim : MonoBehaviour
{
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Shoot.shotPossible == false)
        {
            anim.SetBool("shotPossible", true);
        }
        else
        {
            anim.SetBool("shotPossible", false);
        }
    }
}
