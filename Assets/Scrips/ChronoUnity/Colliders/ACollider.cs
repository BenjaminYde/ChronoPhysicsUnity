using UnityEngine;

namespace ChronoUnity
{
    public abstract class ACollider : MonoBehaviour
    {
        // .. FIELDS

        protected RigidBody rigidBody { get; private set; }
        protected System system { get; private set; }

        // .. INITIALIZATION

        internal virtual void Internal_Initialize()
        {
        }

        internal void Internal_InjectSystem(System system)
        {
            this.system = system;
        }

        internal void Internal_InjectBody(RigidBody rigidBody)
        {
            this.rigidBody = rigidBody;
        }
    }
}