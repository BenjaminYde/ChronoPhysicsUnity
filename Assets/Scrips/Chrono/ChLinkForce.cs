//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkForce : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChLinkForce(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkForce obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChLinkForce() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ChronoEngine_csharpPINVOKE.delete_ChLinkForce(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChLinkForce() : this(ChronoEngine_csharpPINVOKE.new_ChLinkForce__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkForce(ChLinkForce other) : this(ChronoEngine_csharpPINVOKE.new_ChLinkForce__SWIG_1(ChLinkForce.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkForce Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkForce_Clone(swigCPtr);
    ChLinkForce ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkForce(cPtr, false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsActive() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkForce_IsActive(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetActive(bool val) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_SetActive(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetF() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkForce_GetF(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetF(double F) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_SetF(swigCPtr, F);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetK() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkForce_GetK(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetK(double K) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_SetK(swigCPtr, K);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetR() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkForce_GetR(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetR(double R) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_SetR(swigCPtr, R);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction GetModulationF() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkForce_GetModulationF(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFunction GetModulationK() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkForce_GetModulationK(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFunction GetModulationR() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkForce_GetModulationR(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetModulationF(ChFunction funct) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_SetModulationF(swigCPtr, ChFunction.getCPtr(funct));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetModulationK(ChFunction funct) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_SetModulationK(swigCPtr, ChFunction.getCPtr(funct));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetModulationR(ChFunction funct) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_SetModulationR(swigCPtr, ChFunction.getCPtr(funct));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetFcurrent(double x, double x_dt, double t) {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkForce_GetFcurrent(swigCPtr, x, x_dt, t);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetKcurrent(double x, double x_dt, double t) {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkForce_GetKcurrent(swigCPtr, x, x_dt, t);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRcurrent(double x, double x_dt, double t) {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkForce_GetRcurrent(swigCPtr, x, x_dt, t);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetForce(double x, double x_dt, double t) {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkForce_GetForce(swigCPtr, x, x_dt, t);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkForce_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}