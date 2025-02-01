using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject laser;

    private bool isFiring = false;

    private void Update()
    {
        ProcessFiring();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    private void ProcessFiring()
    {
        var laserEmission = laser.GetComponent<ParticleSystem>().emission;

        if (isFiring)
        {
            laserEmission.enabled = true;
        }
        else
        {
            laserEmission.enabled = false;
        }
    }
}
