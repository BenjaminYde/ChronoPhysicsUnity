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
            //var collisionM = nativeBody.GetCollisionModel();
            
            // see source cpp:
            // ChCollisionModelBullet
            // - ChCollisionModelBullet::AddConvexHull
            // -- bt_utils::ChConvexHullLibraryWrapper.ComputeHull(...)
            // 
            
        }
    }
}