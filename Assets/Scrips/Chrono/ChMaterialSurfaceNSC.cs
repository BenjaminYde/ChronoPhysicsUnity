//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChMaterialSurfaceNSC : ChMaterialSurface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChMaterialSurfaceNSC(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChMaterialSurfaceNSC_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChMaterialSurfaceNSC obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChMaterialSurfaceNSC(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChMaterialSurfaceNSC() : this(corePINVOKE.new_ChMaterialSurfaceNSC__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChMaterialSurfaceNSC(ChMaterialSurfaceNSC other) : this(corePINVOKE.new_ChMaterialSurfaceNSC__SWIG_1(ChMaterialSurfaceNSC.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChMaterialSurface Clone() {
    global::System.IntPtr cPtr = corePINVOKE.ChMaterialSurfaceNSC_Clone(swigCPtr);
    ChMaterialSurfaceNSC ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMaterialSurfaceNSC(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChContactMethod GetContactMethod() {
    ChContactMethod ret = (ChContactMethod)corePINVOKE.ChMaterialSurfaceNSC_GetContactMethod(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetCohesion() {
    float ret = corePINVOKE.ChMaterialSurfaceNSC_GetCohesion(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCohesion(float mval) {
    corePINVOKE.ChMaterialSurfaceNSC_SetCohesion(swigCPtr, mval);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetDampingF() {
    float ret = corePINVOKE.ChMaterialSurfaceNSC_GetDampingF(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDampingF(float mval) {
    corePINVOKE.ChMaterialSurfaceNSC_SetDampingF(swigCPtr, mval);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetCompliance() {
    float ret = corePINVOKE.ChMaterialSurfaceNSC_GetCompliance(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCompliance(float mval) {
    corePINVOKE.ChMaterialSurfaceNSC_SetCompliance(swigCPtr, mval);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetComplianceT() {
    float ret = corePINVOKE.ChMaterialSurfaceNSC_GetComplianceT(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetComplianceT(float mval) {
    corePINVOKE.ChMaterialSurfaceNSC_SetComplianceT(swigCPtr, mval);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetComplianceRolling() {
    float ret = corePINVOKE.ChMaterialSurfaceNSC_GetComplianceRolling(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetComplianceRolling(float mval) {
    corePINVOKE.ChMaterialSurfaceNSC_SetComplianceRolling(swigCPtr, mval);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetComplianceSpinning() {
    float ret = corePINVOKE.ChMaterialSurfaceNSC_GetComplianceSpinning(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetComplianceSpinning(float mval) {
    corePINVOKE.ChMaterialSurfaceNSC_SetComplianceSpinning(swigCPtr, mval);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    corePINVOKE.ChMaterialSurfaceNSC_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChMaterialSurfaceNSC_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float cohesion {
    set {
      corePINVOKE.ChMaterialSurfaceNSC_cohesion_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurfaceNSC_cohesion_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float dampingf {
    set {
      corePINVOKE.ChMaterialSurfaceNSC_dampingf_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurfaceNSC_dampingf_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float compliance {
    set {
      corePINVOKE.ChMaterialSurfaceNSC_compliance_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurfaceNSC_compliance_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float complianceT {
    set {
      corePINVOKE.ChMaterialSurfaceNSC_complianceT_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurfaceNSC_complianceT_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float complianceRoll {
    set {
      corePINVOKE.ChMaterialSurfaceNSC_complianceRoll_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurfaceNSC_complianceRoll_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float complianceSpin {
    set {
      corePINVOKE.ChMaterialSurfaceNSC_complianceSpin_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurfaceNSC_complianceSpin_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
