using Entity;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSens;
    public Transform tf;
    
    private float _xRotation = 0f;
     
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        tf.Rotate(Vector3.up * mouseX);
        Debug.Log(tf.localRotation);
    }
}
