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
                ChVectorD point1 = vertices[triangles[it + 0]].ToChronoVector3();
                ChVectorD point2 = vertices[triangles[it + 1]].ToChronoVector3();
                ChVectorD point3 = vertices[triangles[it + 2]].ToChronoVector3();

                var triangle = new ChTriangle(point1, point2, point3);
                chTriangleMesh.addTriangle(triangle);
            }

            chTriangleMesh.RepairDuplicateVertexes();

            return chTriangleMesh;
        }
    }
}