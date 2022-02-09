//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChBodyEasyConvexHull : ChBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChBodyEasyConvexHull(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChBodyEasyConvexHull_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChBodyEasyConvexHull obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChBodyEasyConvexHull(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChBodyEasyConvexHull(vector_ChVectorD points, double density, bool visualize, bool collide, ChMaterialSurface material, ChCollisionModel collision_model) : this(corePINVOKE.new_ChBodyEasyConvexHull__SWIG_0(vector_ChVectorD.getCPtr(points), density, visualize, collide, ChMaterialSurface.getCPtr(material), ChCollisionModel.getCPtr(collision_model)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyConvexHull(vector_ChVectorD points, double density, bool visualize, bool collide, ChMaterialSurface material) : this(corePINVOKE.new_ChBodyEasyConvexHull__SWIG_1(vector_ChVectorD.getCPtr(points), density, visualize, collide, ChMaterialSurface.getCPtr(material)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyConvexHull(vector_ChVectorD points, double density, bool visualize, bool collide) : this(corePINVOKE.new_ChBodyEasyConvexHull__SWIG_2(vector_ChVectorD.getCPtr(points), density, visualize, collide), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyConvexHull(vector_ChVectorD points, double density, bool visualize) : this(corePINVOKE.new_ChBodyEasyConvexHull__SWIG_3(vector_ChVectorD.getCPtr(points), density, visualize), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyConvexHull(vector_ChVectorD points, double density) : this(corePINVOKE.new_ChBodyEasyConvexHull__SWIG_4(vector_ChVectorD.getCPtr(points), density), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyConvexHull(vector_ChVectorD points, double density, ChMaterialSurface material, ChCollisionSystemType collision_type) : this(corePINVOKE.new_ChBodyEasyConvexHull__SWIG_5(vector_ChVectorD.getCPtr(points), density, ChMaterialSurface.getCPtr(material), (int)collision_type), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChTriangleMeshConnected GetMesh() {
    global::System.IntPtr cPtr = corePINVOKE.ChBodyEasyConvexHull_GetMesh(swigCPtr);
    ChTriangleMeshConnected ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChTriangleMeshConnected(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
