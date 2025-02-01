using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float MovementSpeed;
    [SerializeField] float xClampRange;
    [SerializeField] float yClampRange;

    [SerializeField] float rotationValue;
    [SerializeField] float rotationSpeed;

    [SerializeField] float pitchValue;
    [SerializeField] float pitchSpeed;

    Vector2 movement;

    private void Update()
    {
        UpdateShipPosition();
        UpdateShipRoll();
        UpdateShipPitch();
    }


    public void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    private void UpdateShipPosition()
    {
        float xOffset = movement.x * MovementSpeed * Time.deltaTime;
        float yOffset = movement.y * MovementSpeed * Time.deltaTime;

        float finalisedXPosition = Mathf.Clamp(transform.localPosition.x + xOffset, -xClampRange, xClampRange);
        float finalisedYPosition = Mathf.Clamp(transform.localPosition.y + yOffset, -yClampRange, yClampRange);

        transform.localPosition = new Vector3(finalisedXPosition, finalisedYPosition, 0f);
    }

    private void UpdateShipRoll()
    {
        Quaternion newQuaternion = Quaternion.Euler(0f, 0f, -rotationValue * movement.x);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, newQuaternion, rotationSpeed * Time.deltaTime);
    }

    private void UpdateShipPitch()
    {
        Quaternion newQuaternion = Quaternion.Euler(-pitchValue * movement.y, 0f, 0f);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, newQuaternion, pitchSpeed * Time.deltaTime);
    }
}
