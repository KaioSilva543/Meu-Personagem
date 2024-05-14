using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private PlayerController player;
    private Animator Anim;

    void Awake()
    {
        Anim = GetComponent<Animator>();
        player = GetComponent<PlayerController>();
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        MoveAnim();
    }

    void MoveAnim()
    {
        if (player.Move1)
        {
            Anim.SetInteger("Transicao", 1);
        }
        else
        {
            Anim.SetInteger("Transicao", 0);
        }
    }
}
