using ChronoUnity.Debug;
using UnityEditor;
using UnityEngine;

namespace ChronoUnity
{
    public class MeshCollider : ACollider
    {
        // .. FIELDS

        public bool IsConvex = false;
        public Mesh Mesh = null;
        
        // .. INITIALIZATION

        internal override void Internal_Initialize()
        {
            var drawer = new BodyDrawer(this.rigidBody);
            this.system.AddGizmoDrawer(drawer);
        }

        // .. DEBUG

        private class BodyDrawer : AGizmoDrawer
        {
            private readonly RigidBody rigidBody;
            
            public BodyDrawer(RigidBody rigidBody)
            {
                this.rigidBody = rigidBody;
            }

            public override void BeforeDraw()
            {
                // check if can draw
                var activeObject = Selection.activeGameObject;
                bool canDraw = activeObject != null &&
                               activeObject.GetInstanceID() == rigidBody.gameObject.GetInstanceID();

                // set visualization
                var nativeBody = rigidBody.GetBody();
                nativeBody.SetShowCollisionMesh(canDraw); // this does not work? (obsolete in cpp source)
            }

            protected override void DrawLine(Vector3 @from, Vector3 to)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawLine(from, to);
            }
        }
    }
}