using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [Header("LavaDamage")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;

    [Header("AssociationWithPlayer")]
    public PlayerController player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>(); // find the player
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
        player.TakeDamage(damage); // create damage onto the player
    }
}
