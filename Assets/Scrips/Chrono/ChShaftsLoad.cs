//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChShaftsLoad : ChLoadCustomMultiple {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChShaftsLoad(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChShaftsLoad_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChShaftsLoad obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChShaftsLoad(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void ComputeShaftShaftTorque(double rel_rot, double rel_rot_dt, SWIGTYPE_p_double result_torque) {
    ChronoEngine_csharpPINVOKE.ChShaftsLoad_ComputeShaftShaftTorque(swigCPtr, rel_rot, rel_rot_dt, SWIGTYPE_p_double.getCPtr(result_torque));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTorque() {
    double ret = ChronoEngine_csharpPINVOKE.ChShaftsLoad_GetTorque(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChShaft GetShaftA() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChShaftsLoad_GetShaftA(swigCPtr);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChShaft GetShaftB() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChShaftsLoad_GetShaftB(swigCPtr);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
