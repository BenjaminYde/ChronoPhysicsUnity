using System;
using System.Collections.Generic;
using UnityEngine;

namespace ChronoUnity
{
    public class System : MonoBehaviour
    {
        // .. STATIC

        private static System staticSystem = null;
        private static bool isInitialized = false;

        // .. FIELDS
        
        [Header("Settings")]
        public float StepTime = 0.01f;
        public ChSolver.Type SolverType = ChSolver.Type.PSOR;
        public bool UseSleeping = false;
        private ChSystem system;
        private readonly HashSet<RigidBody> rigidBodies = new HashSet<RigidBody>();
        
        // .. INITIALIZATION

        private void DisposeSystem()
        {
            // check if need to cleanup
            if (!isInitialized)
                return;
            
            // cleanup
            this.system.Dispose();
            this.system = null;
            this.rigidBodies.Clear();
            isInitialized = false;
        }

        private void InitializeSystem()
        {
            // check if initialized already
            if (isInitialized)
                throw new Exception("System is already initialized! Please dispose first!");

            // create system
            this.system = new ChSystemNSC();
            
            // set parameters
            this.system.SetChTime(0);
            this.system.SetStepMax(StepTime*2);
            this.system.SetSolverMaxIterations(40);
            this.system.SetMaxPenetrationRecoverySpeed(1);
            this.system.SetUseSleeping(UseSleeping);

            this.system.SetSolverType(SolverType);

            // finish
            staticSystem = this;
            isInitialized = true;
        }
        
        // .. MONO
        
        private void Awake()
        {
            InitializeSystem();
        }

        private void OnDestroy()
        {
            DisposeSystem();
        }
        
        private void Update()
        {
            // check if valid
            if (!isInitialized)
                return;
            
            // do simulation step
            system.DoStepDynamics(StepTime);
            
            // set transform of simulated rigid bodies
            foreach (var rigidBody in rigidBodies)
            {
                var body = rigidBody.GetBody();
                var chBodyPosition = body.GetPos();
                var chBodyRotation = body.GetRot();
                
                var rigidBodyTransform = rigidBody.transform;
                
                var unityBodyPosition = new Vector3((float)chBodyPosition.x, (float)chBodyPosition.y, (float)chBodyPosition.z);
                rigidBodyTransform.position = unityBodyPosition;
                var unityBodyRotation = new UnityEngine.Quaternion((float)chBodyRotation.e1, (float)chBodyRotation.e2, (float)chBodyRotation.e3, (float)chBodyRotation.e0);
                rigidBodyTransform.rotation = unityBodyRotation;
            }
        }

        // .. STATIC PUBLIC

        public static System GetSystem()
        {
            if (!isInitialized)
                throw new Exception("Referencing a non-initialized Chrono System! Reference it after initialization!");
            return staticSystem;
        }

        // .. PUBLIC
        
        public void AddRigidBody(RigidBody rigidBody)
        {
            var body = rigidBody.GetBody();
            system.Add(body);
            this.rigidBodies.Add(rigidBody);
        }
    }
}