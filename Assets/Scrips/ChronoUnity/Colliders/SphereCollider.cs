using UnityEngine;

namespace ChronoUnity
{
    public class SphereCollider : ACollider
    {
        // .. PROPERTIES

        public float Radius => radius;
        
        // .. FIELDS

        [Header("Settings")] 
        [SerializeField] 
        private float radius = 0.5f;
        
        // .. DEBUG

        private void OnDrawGizmosSelected()
        {
            var thisTransform = this.transform;
            Gizmos.matrix = Matrix4x4.TRS(thisTransform.position, thisTransform.rotation, Vector3.one);

            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(Vector3.zero, this.radius + 0.001f);
        }
    }
}