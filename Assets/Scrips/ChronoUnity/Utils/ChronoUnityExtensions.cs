using UnityEngine;

namespace ChronoUnity.Utils
{
    public static class ChronoUnityExtensions
    {
        public static Vector3 ToUnityVector3(this ChVectorD chronoVector)
        {
            return new Vector3((float)chronoVector.x, (float)chronoVector.y, (float)chronoVector.z);
        }
        
        public static ChVectorD ToChronoVector3(this Vector3 unityVector)
        {
            return new ChVectorD(unityVector.x, unityVector.y, unityVector.z);
        }

        public static Quaternion ToUnityQuaternion(this ChQuaternionD chronoQuaternion)
        {
            return new Quaternion((float)chronoQuaternion.e1, (float)chronoQuaternion.e2, (float)chronoQuaternion.e3, (float)chronoQuaternion.e0);
        }
        
        public static ChQuaternionD ToChronoQuaternion(this Quaternion unityQuaternion)
        {
            return new ChQuaternionD(unityQuaternion.w, unityQuaternion.x, unityQuaternion.y, unityQuaternion.z);
        }
    }
}