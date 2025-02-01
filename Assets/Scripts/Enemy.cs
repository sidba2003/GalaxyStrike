using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem DestructionEffect;

    private void OnParticleCollision(GameObject other)
    {
        Instantiate(DestructionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject.transform.parent.transform.parent.gameObject);
    }
}
