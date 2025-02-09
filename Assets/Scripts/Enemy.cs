using System;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem DestructionEffect;
    [SerializeField] int hitPoints;

    Scoreboard scoreboard;

    private void Start()
    {
        scoreboard = Scoreboard.instance;
    }

    private void OnParticleCollision(GameObject other)
    {
        hitPoints--;

        if (hitPoints == 0)
        {
            scoreboard.increaseScore();

            Instantiate(DestructionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject.transform.parent.transform.parent.gameObject);
        }
    }
}
