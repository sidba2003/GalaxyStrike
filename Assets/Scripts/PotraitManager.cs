using UnityEngine;

public class PotraitManager : MonoBehaviour
{
    [SerializeField] RectTransform potrait1;
    [SerializeField] RectTransform potrait2;

    private void Start()
    {
        potrait1.gameObject.SetActive(false);
        potrait2.gameObject.SetActive(false);
    }

    public void DisplayPotrait1()
    {
        potrait1.gameObject.SetActive(true);
    }

    public void HidePotrait1()
    {
        potrait1.gameObject.SetActive(false);
    }

    public void DisplayPotrait2()
    {
        potrait2.gameObject.SetActive(true);
    }

    public void HidePotrait2()
    {
        potrait2.gameObject.SetActive(false);
    }
}
