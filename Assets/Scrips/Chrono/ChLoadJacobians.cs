//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadJacobians : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChLoadJacobians(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadJacobians obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChLoadJacobians() {
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
          ChronoEngine_csharpPINVOKE.delete_ChLoadJacobians(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_ChKblockGeneric KRM {
    set {
      ChronoEngine_csharpPINVOKE.ChLoadJacobians_KRM_set(swigCPtr, SWIGTYPE_p_ChKblockGeneric.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_ChKblockGeneric ret = new SWIGTYPE_p_ChKblockGeneric(ChronoEngine_csharpPINVOKE.ChLoadJacobians_KRM_get(swigCPtr), true);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChMatrixDynamicD K {
    set {
      ChronoEngine_csharpPINVOKE.ChLoadJacobians_K_set(swigCPtr, ChMatrixDynamicD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLoadJacobians_K_get(swigCPtr);
      ChMatrixDynamicD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMatrixDynamicD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChMatrixDynamicD R {
    set {
      ChronoEngine_csharpPINVOKE.ChLoadJacobians_R_set(swigCPtr, ChMatrixDynamicD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLoadJacobians_R_get(swigCPtr);
      ChMatrixDynamicD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMatrixDynamicD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChMatrixDynamicD M {
    set {
      ChronoEngine_csharpPINVOKE.ChLoadJacobians_M_set(swigCPtr, ChMatrixDynamicD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLoadJacobians_M_get(swigCPtr);
      ChMatrixDynamicD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMatrixDynamicD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void SetVariables(SWIGTYPE_p_std__vectorT_ChVariables_p_t mvariables) {
    ChronoEngine_csharpPINVOKE.ChLoadJacobians_SetVariables(swigCPtr, SWIGTYPE_p_std__vectorT_ChVariables_p_t.getCPtr(mvariables));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLoadJacobians() : this(ChronoEngine_csharpPINVOKE.new_ChLoadJacobians(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}