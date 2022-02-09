//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChBodyEasyEllipsoid : ChBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChBodyEasyEllipsoid(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChBodyEasyEllipsoid_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChBodyEasyEllipsoid obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChBodyEasyEllipsoid(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChBodyEasyEllipsoid(ChVectorD radius, double density, bool visualize, bool collide, ChMaterialSurface material, ChCollisionModel collision_model) : this(corePINVOKE.new_ChBodyEasyEllipsoid__SWIG_0(ChVectorD.getCPtr(radius), density, visualize, collide, ChMaterialSurface.getCPtr(material), ChCollisionModel.getCPtr(collision_model)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyEllipsoid(ChVectorD radius, double density, bool visualize, bool collide, ChMaterialSurface material) : this(corePINVOKE.new_ChBodyEasyEllipsoid__SWIG_1(ChVectorD.getCPtr(radius), density, visualize, collide, ChMaterialSurface.getCPtr(material)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyEllipsoid(ChVectorD radius, double density, bool visualize, bool collide) : this(corePINVOKE.new_ChBodyEasyEllipsoid__SWIG_2(ChVectorD.getCPtr(radius), density, visualize, collide), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyEllipsoid(ChVectorD radius, double density, bool visualize) : this(corePINVOKE.new_ChBodyEasyEllipsoid__SWIG_3(ChVectorD.getCPtr(radius), density, visualize), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyEllipsoid(ChVectorD radius, double density) : this(corePINVOKE.new_ChBodyEasyEllipsoid__SWIG_4(ChVectorD.getCPtr(radius), density), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyEllipsoid(ChVectorD radius, double density, ChMaterialSurface material, ChCollisionSystemType collision_type) : this(corePINVOKE.new_ChBodyEasyEllipsoid__SWIG_5(ChVectorD.getCPtr(radius), density, ChMaterialSurface.getCPtr(material), (int)collision_type), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
