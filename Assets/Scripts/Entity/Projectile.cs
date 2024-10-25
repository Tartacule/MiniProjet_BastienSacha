using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Entity
{
    //General class for all projectile types in the game
    //Can be added as a Component given link to MonoBehaviour
    public abstract class Projectile : MonoBehaviour
    {
        public string name;
        public float launchSpeed;
        public int destroyTime;
        public Rigidbody rigidBody;

        protected bool _launched;
        protected bool _landed;
        
        
        public abstract void Create();
        public abstract void Launch(float launchSpeed);
        public abstract void Remove();
        

        protected virtual void CheckRotation() {
            if (!_launched) return;
            transform.forward = rigidBody.velocity;
        }

        protected virtual void OnCollisionEnter(Collision other) {
            Remove();
        }
    }
}