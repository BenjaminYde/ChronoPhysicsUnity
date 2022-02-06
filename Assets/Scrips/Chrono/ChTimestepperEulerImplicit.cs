//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTimestepperEulerImplicit : ChTimestepperIIorder {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTimestepperEulerImplicit(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTimestepperEulerImplicit obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChTimestepperEulerImplicit(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChTimestepperEulerImplicit(ChIntegrableIIorder intgr) : this(ChronoEngine_csharpPINVOKE.new_ChTimestepperEulerImplicit__SWIG_0(ChIntegrableIIorder.getCPtr(intgr)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChTimestepperEulerImplicit() : this(ChronoEngine_csharpPINVOKE.new_ChTimestepperEulerImplicit__SWIG_1(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChTimestepper.Type GetType() {
    ChTimestepper.Type ret = (ChTimestepper.Type)ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_GetType(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Advance(double dt) {
    ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_Advance(swigCPtr, dt);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxiters(int iters) {
    ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_SetMaxiters(swigCPtr, iters);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRelTolerance(double rel_tol) {
    ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_SetRelTolerance(swigCPtr, rel_tol);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAbsTolerances(double abs_tolS, double abs_tolL) {
    ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_SetAbsTolerances__SWIG_0(swigCPtr, abs_tolS, abs_tolL);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAbsTolerances(double abs_tol) {
    ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_SetAbsTolerances__SWIG_1(swigCPtr, abs_tol);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetNumIterations() {
    int ret = ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_GetNumIterations(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumSetupCalls() {
    int ret = ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_GetNumSetupCalls(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumSolveCalls() {
    int ret = ChronoEngine_csharpPINVOKE.ChTimestepperEulerImplicit_GetNumSolveCalls(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}