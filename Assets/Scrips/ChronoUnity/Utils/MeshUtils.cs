using UnityEngine;

namespace ChronoUnity.Utils
{
    public static class MeshUtils
    {
        public static ChTriangleMesh CreateChTriangleMesh(Mesh mesh)
        {
            var chTriangleMesh = new ChTriangleMeshConnected();
            
            var triangles = mesh.triangles;
            var vertices = mesh.vertices;
            
            for (int it = 0; it < triangles.Length; it+=3)
            {
                Vector3 p1 = vertices[triangles[it + 0]];
                Vector3 p2 = vertices[triangles[it + 1]];
                Vector3 p3 = vertices[triangles[it + 2]];

                ChVectorD point1 = new ChVectorD(p1.x, p1.y, p1.z);
                ChVectorD point2 = new ChVectorD(p2.x, p2.y, p2.z);
                ChVectorD point3 = new ChVectorD(p3.x, p3.y, p3.z);

                var triangle = new ChTriangle(point1, point2, point3);
                chTriangleMesh.addTriangle(triangle);
            }

            chTriangleMesh.RepairDuplicateVertexes();

            return chTriangleMesh;
        }
    }
}