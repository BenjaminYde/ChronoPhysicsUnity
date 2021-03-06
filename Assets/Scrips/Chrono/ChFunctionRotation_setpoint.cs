//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunctionRotation_setpoint : ChFunctionRotation {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChFunctionRotation_setpoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunctionRotation_setpoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChFunctionRotation_setpoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFunctionRotation_setpoint() : this(ChronoEngine_csharpPINVOKE.new_ChFunctionRotation_setpoint__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_setpoint(ChFunctionRotation_setpoint other) : this(ChronoEngine_csharpPINVOKE.new_ChFunctionRotation_setpoint__SWIG_1(ChFunctionRotation_setpoint.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChFunctionRotation Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_Clone(swigCPtr);
    ChFunctionRotation_setpoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunctionRotation_setpoint(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMode(ChFunctionRotation_setpoint.eChSetpointMode mmode) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_SetMode(swigCPtr, (int)mmode);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_setpoint.eChSetpointMode GetMode() {
    ChFunctionRotation_setpoint.eChSetpointMode ret = (ChFunctionRotation_setpoint.eChSetpointMode)ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_GetMode(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reset(double ms) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_Reset__SWIG_0(swigCPtr, ms);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reset() {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_Reset__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetSetpoint(ChQuaternionD q_setpoint, double s) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_SetSetpoint(swigCPtr, ChQuaternionD.getCPtr(q_setpoint), s);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetSetpointAndDerivatives(ChQuaternionD q_setpoint, ChVectorD w_loc_setpoint, ChVectorD a_loc_setpoint) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_SetSetpointAndDerivatives(swigCPtr, ChQuaternionD.getCPtr(q_setpoint), ChVectorD.getCPtr(w_loc_setpoint), ChVectorD.getCPtr(a_loc_setpoint));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChQuaternionD Get_q(double s) {
    ChQuaternionD ret = new ChQuaternionD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_Get_q(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD Get_w_loc(double s) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_Get_w_loc(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD Get_a_loc(double s) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_Get_a_loc(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_setpoint_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum eChSetpointMode {
    ZOH,
    FOH,
    OVERRIDE
  }

}
