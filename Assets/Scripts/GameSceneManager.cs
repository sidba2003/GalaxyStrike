using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] float TimeToDestroy;

    public static GameSceneManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void ReloadScene()
    {
        StartCoroutine(ReloadSceneRoutine());
    }

    IEnumerator ReloadSceneRoutine()
    {
        yield return new WaitForSeconds(TimeToDestroy);

        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
