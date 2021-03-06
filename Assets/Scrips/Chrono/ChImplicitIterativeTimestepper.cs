//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChImplicitIterativeTimestepper : ChImplicitTimestepper {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChImplicitIterativeTimestepper(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChImplicitIterativeTimestepper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChImplicitIterativeTimestepper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChImplicitIterativeTimestepper() : this(ChronoEngine_csharpPINVOKE.new_ChImplicitIterativeTimestepper(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxiters(int iters) {
    ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_SetMaxiters(swigCPtr, iters);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetMaxiters() {
    double ret = ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_GetMaxiters(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRelTolerance(double rel_tol) {
    ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_SetRelTolerance(swigCPtr, rel_tol);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAbsTolerances(double abs_tolS, double abs_tolL) {
    ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_SetAbsTolerances__SWIG_0(swigCPtr, abs_tolS, abs_tolL);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAbsTolerances(double abs_tol) {
    ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_SetAbsTolerances__SWIG_1(swigCPtr, abs_tol);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetNumIterations() {
    int ret = ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_GetNumIterations(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumSetupCalls() {
    int ret = ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_GetNumSetupCalls(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumSolveCalls() {
    int ret = ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_GetNumSolveCalls(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ArchiveOUT(SWIGTYPE_p_ChArchiveOut archive) {
    ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(archive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn archive) {
    ChronoEngine_csharpPINVOKE.ChImplicitIterativeTimestepper_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
