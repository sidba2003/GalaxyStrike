using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;

    [SerializeField] GameObject target;
    [SerializeField] float targetZDistance;

    private bool isFiring = false;

    private void Start(){
        Cursor.visible = false;
    }

    private void Update()
    {
        ProcessFiring();
        ProcessCrosshairMovement();
        ProcessTargetLocation();
        ProcessLaserRotation();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    private void ProcessFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emission = laser.GetComponent<ParticleSystem>().emission;
            emission.enabled = isFiring;
        }
    }

    private void ProcessCrosshairMovement(){
        crosshair.position = Input.mousePosition;
    }

    private void ProcessTargetLocation()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(
                                    new Vector3(
                                           Input.mousePosition.x, 
                                           Input.mousePosition.y, 
                                           targetZDistance
                                           )
                                    );
        target.transform.position = mousePosition;
    }

    private void ProcessLaserRotation() {
        foreach (GameObject laser in lasers) { 
            Vector3 aimDirection = target.transform.position - laser.transform.position;
            Quaternion aimRotation = Quaternion.LookRotation(aimDirection);
            laser.transform.rotation = aimRotation;
        }
    }
}
