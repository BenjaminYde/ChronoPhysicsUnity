//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadBodyForce : ChLoadCustom {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadBodyForce(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLoadBodyForce_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadBodyForce obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLoadBodyForce(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadBodyForce(ChBody body, ChVectorD force, bool local_force, ChVectorD point, bool local_point) : this(ChronoEngine_csharpPINVOKE.new_ChLoadBodyForce__SWIG_0(ChBody.getCPtr(body), ChVectorD.getCPtr(force), local_force, ChVectorD.getCPtr(point), local_point), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLoadBodyForce(ChBody body, ChVectorD force, bool local_force, ChVectorD point) : this(ChronoEngine_csharpPINVOKE.new_ChLoadBodyForce__SWIG_1(ChBody.getCPtr(body), ChVectorD.getCPtr(force), local_force, ChVectorD.getCPtr(point)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLoadBodyForce_Clone(swigCPtr);
    ChLoadBodyForce ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLoadBodyForce(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetForce(ChVectorD force, bool is_local) {
    ChronoEngine_csharpPINVOKE.ChLoadBodyForce_SetForce(swigCPtr, ChVectorD.getCPtr(force), is_local);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetForce() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoadBodyForce_GetForce(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetApplicationPoint(ChVectorD point, bool is_local) {
    ChronoEngine_csharpPINVOKE.ChLoadBodyForce_SetApplicationPoint(swigCPtr, ChVectorD.getCPtr(point), is_local);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetApplicationPoint() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoadBodyForce_GetApplicationPoint(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetModulationFunction(ChFunction modulation) {
    ChronoEngine_csharpPINVOKE.ChLoadBodyForce_SetModulationFunction(swigCPtr, ChFunction.getCPtr(modulation));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeQ(ChState state_x, ChStateDelta state_w) {
    ChronoEngine_csharpPINVOKE.ChLoadBodyForce_ComputeQ(swigCPtr, ChState.getCPtr(state_x), ChStateDelta.getCPtr(state_w));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
