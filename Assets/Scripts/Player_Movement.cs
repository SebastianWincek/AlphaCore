using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class Player_Movement : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;
    public float pushForce = 3.0f;
    float verticalRotation = 0;
    public float verticalRotationLimit = 80;
    float horizontalRotation = 0;

    private CharacterController _charController;
    private ControllerColliderHit _contact;

    void Awake()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Time.timeScale == 1)
        {
            horizontalRotation = Input.GetAxis("Mouse X");
            verticalRotation -= Input.GetAxis("Mouse Y");

            transform.Rotate(0, horizontalRotation, 0);

            verticalRotation = Mathf.Clamp(verticalRotation, -verticalRotationLimit, verticalRotationLimit);
            Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        }

        



        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
       // movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;

        //movement *= Time.deltaTime;
        //movement = transform.TransformDirection(movement);
        _charController.Move(transform.rotation *movement * Time.deltaTime);
   
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        _contact = hit;
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body != null && !body.isKinematic)
        {
            body.velocity = hit.moveDirection * pushForce;
        }
    }

}