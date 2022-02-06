using System;
using UnityEngine;

namespace ChronoUnity
{
    public class RigidBody : MonoBehaviour
    {
        // .. FIELDS

        [Header("Settings")] 
        public bool isFixed = false;

        private ACollider[] colliders = Array.Empty<ACollider>();
        private ChBody body = new ChBody();
        private bool isInitialized = false;
        
        // .. INITIALIZATION
        
        private void TryInitialize()
        {
            // check if initialized
            if (isInitialized)
                return;
            
            var thisTransform = this.transform;

            // set settings
            body.SetCollide(true);
            body.SetBodyFixed(isFixed);
            body.SetDensity(1 * thisTransform.localScale.magnitude);
            
            var material = ChMaterialSurface.DefaultMaterial(ChContactMethod.NSC);

            // set position
            var position = thisTransform.position;
            body.SetPos(new ChVectorD(position.x, position.y, position.z));
            
            // get all colliders (components from game object)
            this.colliders = GetComponents<ACollider>();

            // add colliders to body
            var collisionModel = body.GetCollisionModel();
            foreach (var collider in colliders)
            {
                if (collider is BoxCollider boxCollider)
                {
                    var halfSize = boxCollider.Size/2;
                    var scale = boxCollider.transform.localScale;
                    collisionModel.AddBox(material, halfSize.x * scale.x, halfSize.y * scale.y, halfSize.z * scale.z);
                }
            }
            
            // finish
            this.isInitialized = true;
        }

        // .. MONO

        private void Awake()
        {
            TryInitialize();
        }

        private void Start()
        {
            // get system
            var system = System.GetSystem();
            
            // add rigidbody to system
            system.AddRigidBody(this);
        }

        // .. PUBLIC
        
        public ACollider[] GetColliders()
        {
            TryInitialize();
            return this.colliders;
        }

        public ChBody GetBody()
        {
            TryInitialize();
            return body;
        }
    }
}