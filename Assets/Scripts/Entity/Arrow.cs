using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Entity
{
    //General class for arrows
    public class Arrow : Projectile
    {
        private void Start()
        {
            Create();
        }

        private void Update()
        {
            Launch();
            CheckRotation();
        }
        
        public override void Create()
        {
            rigidBody.isKinematic = true;
        }

        public override void Launch()
        {
            if (!_launched && Input.GetKeyDown(KeyCode.Space))
            {
                transform.SetParent(null);
                rigidBody.isKinematic = false;
                _launched = true;
                
                rigidBody.AddForce(transform.forward * launchSpeed, ForceMode.Impulse);
            }
        }
        public override void Remove()
        {
            Destroy(gameObject, 3f);
        }
    }
}
