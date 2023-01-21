using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneAliens : MonoBehaviour
{
    [Header("Enemy Health")]
    public int curHP;
    public int maxHP;

    [Header("Enemy Attack")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public PlayerController player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>(); //find the player
    }
    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack(); // attack the player when they are in range
        }
    }
    void Attack()
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);// create damage on the player
    }

}
