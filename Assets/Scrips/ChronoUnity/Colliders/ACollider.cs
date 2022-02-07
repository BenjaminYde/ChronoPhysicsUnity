using UnityEngine;

namespace ChronoUnity
{
    public abstract class ACollider : MonoBehaviour
    {
        // .. FIELDS

        protected ChBody nativeBody { get; private set; }
        
        // .. INITIALIZATION

        internal void Internal_InjectBody(ChBody chronoBody)
        {
            this.nativeBody = chronoBody;

        }
    }
}