using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Variaveis")]
    [SerializeField] private float Velocidade;

    private Rigidbody2D rbPlayer;
    private SpriteRenderer SrPlayer;
    private Vector2 Direcao;

    private bool Move;

    

    void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        SrPlayer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {

    }


    void Update()
    {
        OnIpunt();
    }

    void FixedUpdate()
    {
        MovePlayer(); 
    }

    void OnIpunt()
    {
        Direcao.x = Input.GetAxisRaw("Horizontal");
    }

    //MOVIMENTO
    void MovePlayer()
    {
        //MOVIMENTO DO PLAYER
        rbPlayer.velocity = new Vector2(Direcao.x * Velocidade, 0);

        //PLAYER VIRANDO PARA ESQUERDA/DIREITA
        if (Direcao.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
            Move = true;
        }
        else if(Direcao.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
            Move = true;
        }
        else
        {
            Move = false;
        }
    }

    //PROPIEDADES
    public bool Move1 { get => Move; set => Move = value; }      
}
