using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] public float _speed = 5.0f;
    [SerializeField] private float _mouseSensitivity = 2.0f;

    private CharacterController characterController;
    private Camera playerCamera;

    private float verticalRotation = 0;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {

        float forwardSpeed = Input.GetAxis("Vertical") * _speed;
        float sideSpeed = Input.GetAxis("Horizontal") * _speed;


        Vector3 speedVector = transform.forward * forwardSpeed + transform.right * sideSpeed;
        characterController.SimpleMove(speedVector);


        float rotLeftRight = Input.GetAxis("Mouse X") * _mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);


        verticalRotation -= Input.GetAxis("Mouse Y") * _mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);
    }
}
