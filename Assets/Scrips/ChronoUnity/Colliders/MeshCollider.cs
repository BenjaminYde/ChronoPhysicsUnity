using UnityEngine;

namespace ChronoUnity
{
    public class MeshCollider : ACollider
    {
        // .. FIELDS

        public bool IsConvex = false;
        public Mesh Mesh = null;

        // .. DEBUG

        private void OnDrawGizmosSelected()
        {
            // todo 
        }
    }
}