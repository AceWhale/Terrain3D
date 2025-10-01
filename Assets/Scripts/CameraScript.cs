using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float moveSpeed = 2f;
    private float scrollSpeed = 10f;
    float horizontalInput;
    float verticalInput;
    float wheelInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        wheelInput = Input.GetAxisRaw("Mouse ScrollWheel");
    }

    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || verticalInput != 0)
        {
            transform.position += moveSpeed * new Vector3(horizontalInput, 0, verticalInput);
        }
        if (Input.GetAxisRaw("Mouse ScrollWheel") != 0)
        {
            transform.position += scrollSpeed * new Vector3(0, -Input.GetAxisRaw("Mouse ScrollWheel"), 0);
        }
    }
}
