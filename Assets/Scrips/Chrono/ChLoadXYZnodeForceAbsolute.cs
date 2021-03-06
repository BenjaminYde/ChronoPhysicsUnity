//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadXYZnodeForceAbsolute : ChLoadXYZnodeForce {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadXYZnodeForceAbsolute(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForceAbsolute_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadXYZnodeForceAbsolute obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLoadXYZnodeForceAbsolute(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadXYZnodeForceAbsolute(SWIGTYPE_p_std__shared_ptrT_ChNodeXYZ_t node, ChVectorD force) : this(ChronoEngine_csharpPINVOKE.new_ChLoadXYZnodeForceAbsolute(SWIGTYPE_p_std__shared_ptrT_ChNodeXYZ_t.getCPtr(node), ChVectorD.getCPtr(force)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForceAbsolute_Clone(swigCPtr);
    ChLoadXYZnodeForceAbsolute ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLoadXYZnodeForceAbsolute(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ComputeForce(ChVectorD abs_pos, ChVectorD abs_vel, ChVectorD abs_force) {
    ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForceAbsolute_ComputeForce(swigCPtr, ChVectorD.getCPtr(abs_pos), ChVectorD.getCPtr(abs_vel), ChVectorD.getCPtr(abs_force));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetForceBase(ChVectorD force) {
    ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForceAbsolute_SetForceBase(swigCPtr, ChVectorD.getCPtr(force));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new ChVectorD GetForce() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForceAbsolute_GetForce(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetModulationFunction(ChFunction modulation) {
    ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForceAbsolute_SetModulationFunction(swigCPtr, ChFunction.getCPtr(modulation));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
