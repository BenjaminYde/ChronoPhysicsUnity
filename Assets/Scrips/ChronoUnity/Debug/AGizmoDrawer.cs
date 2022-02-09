using ChronoUnity.Utils;
using UnityEngine;

namespace ChronoUnity.Debug
{
    public abstract class AGizmoDrawer : VisualizationCallback
    {
        protected bool isEnabled { get; private set; } = true;

        public void EnableDrawer(bool value)
        {
            this.isEnabled = true;
        }

        public sealed override void DrawLine(ChVectorD @from, ChVectorD to, SWIGTYPE_p_ChColor color)
        {
            if (!this.isEnabled)
                return;

            DrawLine(from.ToUnityVector3(), to.ToUnityVector3());
        }
        
        public abstract void BeforeDraw();

        protected abstract void DrawLine(Vector3 from, Vector3 to);
    }
}