using System;
using System.Collections.Generic;
using ChronoUnity.Utils;
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
        public float StepTime = 0.005f;
        public NscSolverType SolverType = NscSolverType.Iterative_VI_PSOR;
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

            // set solver type
            // these are the solver types that work with NSC
            // see SetSolverType() at https://api.projectchrono.org/classchrono_1_1_ch_system.html#ac80b36efe35b16052bd5f356ba7e65ba
            switch (SolverType)
            {
                case NscSolverType.Iterative_VI_APGD:
                    this.system.SetSolver(new ChSolverAPGD());
                    break;
                case NscSolverType.Iterative_VI_BB:
                    this.system.SetSolver(new ChSolverBB());
                    break;
                case NscSolverType.Iterative_VI_PSOR:
                    this.system.SetSolver(new ChSolverPSOR());
                    break;
                case NscSolverType.Iterative_VI_PJACOBI:
                    this.system.SetSolver(new ChSolverPJacobi());
                    break;
                case NscSolverType.Iterative_LS_BICGSTAB:
                    this.system.SetSolver(new ChSolverBiCGSTAB());
                    break;
                case NscSolverType.Iterative_LS_GMRES:
                    this.system.SetSolver(new ChSolverGMRES());
                    break;
                case NscSolverType.Iterative_LS_MINRES:
                    this.system.SetSolver(new ChSolverMINRES());
                    break;
                /*case NscSolverType.Direct_LS_SPARSELU: // this one fails (no collision?)
                    this.system.SetSolver(new ChSolverSparseLU());
                    break;*/
                case NscSolverType.Direct_LS_SPARSEQR:
                    this.system.SetSolver(new ChSolverSparseQR());
                    break;
            }

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
            
            // sync bodies
            SyncTransformChronoBodiesToUnityBodies();
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
        
        // .. PRIVATE

        private void SyncTransformChronoBodiesToUnityBodies()
        {
            // set transform of simulated rigid bodies
            foreach (var rigidBody in rigidBodies)
            {
                rigidBody.SyncChronoTransformToUnityTransform();
            }
        }
    }
}