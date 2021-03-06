//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChIntegrable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChIntegrable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChIntegrable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChIntegrable() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          ChronoEngine_csharpPINVOKE.delete_ChIntegrable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual int GetNcoords_y() {
    int ret = ChronoEngine_csharpPINVOKE.ChIntegrable_GetNcoords_y(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetNcoords_dy() {
    int ret = ChronoEngine_csharpPINVOKE.ChIntegrable_GetNcoords_dy(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetNconstr() {
    int ret = ChronoEngine_csharpPINVOKE.ChIntegrable_GetNconstr(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void StateSetup(ChState y, ChStateDelta dy) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_StateSetup(swigCPtr, ChState.getCPtr(y), ChStateDelta.getCPtr(dy));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void StateGather(ChState y, SWIGTYPE_p_double T) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_StateGather(swigCPtr, ChState.getCPtr(y), SWIGTYPE_p_double.getCPtr(T));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void StateScatter(ChState y, double T, bool full_update) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_StateScatter(swigCPtr, ChState.getCPtr(y), T, full_update);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void StateGatherDerivative(ChStateDelta Dydt) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_StateGatherDerivative(swigCPtr, ChStateDelta.getCPtr(Dydt));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void StateScatterDerivative(ChStateDelta Dydt) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_StateScatterDerivative(swigCPtr, ChStateDelta.getCPtr(Dydt));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void StateGatherReactions(ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_StateGatherReactions(swigCPtr, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void StateScatterReactions(ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_StateScatterReactions(swigCPtr, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool StateSolve(ChStateDelta Dydt, ChVectorDynamicD L, ChState y, double T, double dt, bool force_state_scatter, bool full_update) {
    bool ret = ChronoEngine_csharpPINVOKE.ChIntegrable_StateSolve(swigCPtr, ChStateDelta.getCPtr(Dydt), ChVectorDynamicD.getCPtr(L), ChState.getCPtr(y), T, dt, force_state_scatter, full_update);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void StateIncrement(ChState y_new, ChState y, ChStateDelta Dy) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_StateIncrement(swigCPtr, ChState.getCPtr(y_new), ChState.getCPtr(y), ChStateDelta.getCPtr(Dy));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool StateSolveCorrection(ChStateDelta Dy, ChVectorDynamicD L, ChVectorDynamicD R, ChVectorDynamicD Qc, double a, double b, ChState y, double T, double dt, bool force_state_scatter, bool full_update, bool force_setup) {
    bool ret = ChronoEngine_csharpPINVOKE.ChIntegrable_StateSolveCorrection(swigCPtr, ChStateDelta.getCPtr(Dy), ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(Qc), a, b, ChState.getCPtr(y), T, dt, force_state_scatter, full_update, force_setup);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void LoadResidual_Hv(ChVectorDynamicD R, ChVectorDynamicD v, double c) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_LoadResidual_Hv(swigCPtr, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(v), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LoadResidual_F(ChVectorDynamicD R, double c) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_LoadResidual_F(swigCPtr, ChVectorDynamicD.getCPtr(R), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LoadResidual_CqL(ChVectorDynamicD R, ChVectorDynamicD L, double c) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_LoadResidual_CqL(swigCPtr, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(L), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LoadConstraint_C(ChVectorDynamicD Qc, double c, bool do_clamp, double mclam) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_LoadConstraint_C__SWIG_0(swigCPtr, ChVectorDynamicD.getCPtr(Qc), c, do_clamp, mclam);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LoadConstraint_C(ChVectorDynamicD Qc, double c, bool do_clamp) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_LoadConstraint_C__SWIG_1(swigCPtr, ChVectorDynamicD.getCPtr(Qc), c, do_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LoadConstraint_C(ChVectorDynamicD Qc, double c) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_LoadConstraint_C__SWIG_2(swigCPtr, ChVectorDynamicD.getCPtr(Qc), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LoadConstraint_Ct(ChVectorDynamicD Qc, double c) {
    ChronoEngine_csharpPINVOKE.ChIntegrable_LoadConstraint_Ct(swigCPtr, ChVectorDynamicD.getCPtr(Qc), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
