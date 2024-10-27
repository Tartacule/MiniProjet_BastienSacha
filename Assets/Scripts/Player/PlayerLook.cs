using UnityEngine;
using UnityEngine.EventSystems;

namespace Player
{
    public class PlayerLook : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public float mouseSens;
        public Transform tf;
    
        private float _xRotation = 0f;
     
        // Start is called before the first frame update
        void Start()
        {
            //Cursor.lockState = CursorLockMode.Locked;
        }

        // Update is called once per frame
        void Update() {

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                     Vector2 touchDirection = Input.GetTouch(0).deltaPosition;
                    
                    _xRotation -= touchDirection.y * mouseSens;
                    _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
                    
                    transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
                    tf.Rotate(Vector3.up * (touch.deltaPosition.x * mouseSens));

                }
            }
            /*
            float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        
            _xRotation -= mouseY;
            _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        
            transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
            tf.Rotate(Vector3.up * mouseX);
            //Debug.Log(tf.localRotation);*/
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            throw new System.NotImplementedException();
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    Vector2 touchDirection = touch.deltaPosition;

                    _xRotation -= touchDirection.y;
                    _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

                    transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
                    tf.Rotate(Vector3.up * (touch.deltaPosition.x * mouseSens));

                }
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            throw new System.NotImplementedException();
        }
    }
}
