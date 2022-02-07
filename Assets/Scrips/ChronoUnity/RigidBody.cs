using System;
using ChronoUnity.Utils;
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
        private Transform thisTransform = null;
        
        private bool isInitialized = false;
        
        // .. INITIALIZATION
        
        public void Initialize()
        {
            // check if initialized
            if (isInitialized)
                return;
            
            thisTransform = this.transform;

            // set settings (body)
            body.SetCollide(true);
            body.SetBodyFixed(isFixed);
            body.SetDensity(1 * thisTransform.localScale.magnitude);
            body.SetUseSleeping(true);
            
            // set settings (material)
            var material = new ChMaterialSurfaceNSC();
            material.SetFriction(0.3f);
            //material.SetSfriction(0.1f);
            material.SetRestitution(0);
            material.SetCompliance(0);
            material.SetComplianceT(0);
            material.SetDampingF(0.2f);
            
            // set position
            body.SetPos(thisTransform.position.ToChronoVector3());

            // set rotation
            body.SetRot(thisTransform.rotation.ToChronoQuaternion());
            
            // get all colliders (components from game object)
            this.colliders = GetComponents<ACollider>();

            // add colliders to body
            var collisionModel = body.GetCollisionModel();
            foreach (var collider in colliders)
            {
                // box c
                if (collider is BoxCollider boxCollider)
                {
                    var halfSize = boxCollider.Size/2;
                    var scale = boxCollider.transform.localScale;
                    collisionModel.AddBox(material, halfSize.x * scale.x, halfSize.y * scale.y, halfSize.z * scale.z);
                }
                // sphere vertices
                else if (collider is SphereCollider sphereCollider)
                {
                    collisionModel.AddSphere(material, sphereCollider.Radius);
                }
                // mesh collider
                else if (collider is MeshCollider meshCollider)
                {
                    // get mesh
                    var mesh = meshCollider.Mesh;

                    // if convex
                    if (meshCollider.IsConvex)
                    {
                        var vertices = new vector_ChVectorD();
                        foreach (var vertex in mesh.vertices)
                        {
                            vertices.Add(new ChVectorD(vertex.x, vertex.y, vertex.z));
                        }
                        collisionModel.AddConvexHull(material, vertices);
                    }
                    // if not convex
                    else
                    {
                        var chronoMesh = MeshUtils.CreateChTriangleMesh(mesh);
                        collisionModel.AddTriangleMesh(material, chronoMesh, false, false);
                    }
                }
            }
            
            // build collision model
            collisionModel.BuildModel();

            // finish
            this.isInitialized = true;
        }

        // .. MONO

        private void Awake()
        {
            Initialize();
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
            Initialize();
            return this.colliders;
        }

        public ChBody GetBody()
        {
            Initialize();
            return body;
        }

        public void SyncChronoTransformToUnityTransform()
        {
            // get transform of chrono
            var body = GetBody();
            var chBodyPosition = body.GetPos();
            var chBodyRotation = body.GetRot();
                
            // set transform of rigidbody
            thisTransform.position = chBodyPosition.ToUnityVector3();
            thisTransform.rotation = chBodyRotation.ToUnityQuaternion();
        }
    }
}