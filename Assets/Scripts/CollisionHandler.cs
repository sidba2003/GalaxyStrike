using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class CollisionHandler : MonoBehaviour
{
    [SerializeField] ParticleSystem destructionVFX;

    private GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = GameSceneManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(destructionVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);

        gameSceneManager.ReloadScene();
    }
}
