using UnityEngine;

namespace ChronoUnity
{
    public class BoxCollider : ACollider
    {
        // .. FIELDS

        public Vector3 Size = Vector3.one;
        
        // .. DEBUG

        private void OnDrawGizmosSelected()
        {
            var thisTransform = this.transform;
            Gizmos.matrix = Matrix4x4.TRS(thisTransform.position, thisTransform.rotation, Vector3.one);
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(Vector3.zero, Size + Vector3.one * 0.001f);
            Gizmos.color = new Color(0,1,0,0.25f);
            Gizmos.DrawCube(Vector3.zero, Size + Vector3.one * 0.001f);
        }
    }
}