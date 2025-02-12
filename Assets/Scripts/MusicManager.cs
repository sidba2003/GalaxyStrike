using UnityEngine;

public class MusicManager : MonoBehaviour
{
    void Start()
    {
        int musicManagers = FindObjectsByType<MusicManager>(FindObjectsSortMode.None).Length;
        Debug.Log("Number of music managers are: " + musicManagers);

        if (musicManagers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
