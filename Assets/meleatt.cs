using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleatt : MonoBehaviour
{
    public Transform attackpoint;
    public float attackrange = 2f;
    public LayerMask enemyLayers;
    private Animator anim;
    public Sprite running;
    public Sprite attackSprite;
    public SpriteRenderer sr;


    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            attack();
           
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            anim.SetBool("isAttack",false);
        }
    }
    void attack()
    {
        sr.sprite = attackSprite;
        anim.SetBool("isAttack", true);
        Debug.Log("jedi govna");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
        }
    }
}