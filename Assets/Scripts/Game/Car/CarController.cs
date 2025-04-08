using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private WheelCollider frontLeftWheel, frontRightWheel;
    [SerializeField] private WheelCollider behindLeftWheel, behindRightWheel;

    [SerializeField] private float speed;
    [SerializeField] private float motorForce;

    private Rigidbody carRb;

    public bool isStarted;

    private void Start()
    {
        carRb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(isStarted)
        {
            HandleMotor();
        }
    }

    public void HandleMotor()
    {
        frontLeftWheel.motorTorque = speed * motorForce;
        frontRightWheel.motorTorque = speed * motorForce;
        behindLeftWheel.motorTorque = speed * motorForce;
        behindRightWheel.motorTorque = speed * motorForce;
    }
}
