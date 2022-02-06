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
    }
}