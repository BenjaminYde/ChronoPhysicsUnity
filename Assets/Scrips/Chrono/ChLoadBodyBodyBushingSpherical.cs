//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadBodyBodyBushingSpherical : ChLoadBodyBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadBodyBodyBushingSpherical(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingSpherical_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadBodyBodyBushingSpherical obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLoadBodyBodyBushingSpherical(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadBodyBodyBushingSpherical(ChBody mbodyA, ChBody mbodyB, ChFrameD abs_application, ChVectorD mstiffness, ChVectorD mdamping) : this(ChronoEngine_csharpPINVOKE.new_ChLoadBodyBodyBushingSpherical(ChBody.getCPtr(mbodyA), ChBody.getCPtr(mbodyB), ChFrameD.getCPtr(abs_application), ChVectorD.getCPtr(mstiffness), ChVectorD.getCPtr(mdamping)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingSpherical_Clone(swigCPtr);
    ChLoadBodyBodyBushingSpherical ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLoadBodyBodyBushingSpherical(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetStiffness(ChVectorD mstiffness) {
    ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingSpherical_SetStiffness(swigCPtr, ChVectorD.getCPtr(mstiffness));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetStiffness() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingSpherical_GetStiffness(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDamping(ChVectorD mdamping) {
    ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingSpherical_SetDamping(swigCPtr, ChVectorD.getCPtr(mdamping));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetDamping() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingSpherical_GetDamping(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
