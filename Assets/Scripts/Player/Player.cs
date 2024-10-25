using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {    
        public float movementSpeed;
    
        private Rigidbody _rb;
        private Vector3 _movement;

        private void Awake() {
            _rb = GetComponent<Rigidbody>();
        }

        void Update() {
            // Player Movement
            _movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
            _rb.AddForce(_movement, ForceMode.Force);
        }
    }
}
