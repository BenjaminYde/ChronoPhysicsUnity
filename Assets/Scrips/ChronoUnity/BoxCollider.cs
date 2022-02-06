using System;
using UnityEngine;

namespace ChronoUnity
{
    public class BoxCollider : ACollider
    {
        // .. PROPERTIES

        public Vector3 Size => size;
        
        // .. FIELDS

        [Header("Settings")] 
        [SerializeField]
        private Vector3 size = Vector3.one;
        
        // .. DEBUG

        private void OnDrawGizmosSelected()
        {
            Gizmos.matrix = Matrix4x4.TRS(transform.localPosition, transform.localRotation, transform.localScale);
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(Vector3.zero, size + Vector3.one * 0.001f);
            Gizmos.color = new Color(0,1,0,0.25f);
            Gizmos.DrawCube(Vector3.zero, size + Vector3.one * 0.001f);
        }
    }
}