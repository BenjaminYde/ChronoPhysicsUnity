//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLineCam : ChLine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLineCam(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLineCam_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLineCam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLineCam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLineCam() : this(ChronoEngine_csharpPINVOKE.new_ChLineCam__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineCam(ChLineCam source) : this(ChronoEngine_csharpPINVOKE.new_ChLineCam__SWIG_1(ChLineCam.getCPtr(source)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChGeometry Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLineCam_Clone(swigCPtr);
    ChLineCam ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLineCam(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChGeometry.GeometryType GetClassType() {
    ChGeometry.GeometryType ret = (ChGeometry.GeometryType)ChronoEngine_csharpPINVOKE.ChLineCam_GetClassType(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Get_closed() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_closed(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Set_closed(bool mc) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_closed(swigCPtr, mc);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set_Phase(double mf) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_Phase(swigCPtr, mf);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_Phase() {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_Phase(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_Rb(double mrb) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_Rb(swigCPtr, mrb);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_Rb() {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_Rb(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_Rr(double mrr) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_Rr(swigCPtr, mrr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_Rr() {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_Rr(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_motion_law(SWIGTYPE_p_std__shared_ptrT_ChFunction_t mlaw) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_motion_law(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ChFunction_t.getCPtr(mlaw));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__shared_ptrT_ChFunction_t Get_motion_law() {
    SWIGTYPE_p_std__shared_ptrT_ChFunction_t ret = new SWIGTYPE_p_std__shared_ptrT_ChFunction_t(ChronoEngine_csharpPINVOKE.ChLineCam_Get_motion_law(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_type(eChCamType mt) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_type(swigCPtr, (int)mt);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public eChCamType Get_type() {
    eChCamType ret = (eChCamType)ChronoEngine_csharpPINVOKE.ChLineCam_Get_type(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_center(ChVectorD mc) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_center(swigCPtr, ChVectorD.getCPtr(mc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD Get_center() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLineCam_Get_center(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_Negative(bool val) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_Negative(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Get_Negative() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_Negative(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_Internal(bool val) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_Internal(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Get_Internal() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_Internal(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_rotating_follower(double mp, double md, double mb0) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_rotating_follower(swigCPtr, mp, md, mb0);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_p() {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_p(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get_d() {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_d(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get_b0() {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_b0(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_sliding_eccentrical(double me) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_sliding_eccentrical(swigCPtr, me);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_e() {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_e(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get_s() {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_s(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_flat_oscillate(double me, double md, double mb0) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Set_flat_oscillate(swigCPtr, me, md, mb0);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void EvaluateCamPoint(double par, ChVectorD res, SWIGTYPE_p_double g, SWIGTYPE_p_double q) {
    ChronoEngine_csharpPINVOKE.ChLineCam_EvaluateCamPoint(swigCPtr, par, ChVectorD.getCPtr(res), SWIGTYPE_p_double.getCPtr(g), SWIGTYPE_p_double.getCPtr(q));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Evaluate(ChVectorD pos, double parU) {
    ChronoEngine_csharpPINVOKE.ChLineCam_Evaluate(swigCPtr, ChVectorD.getCPtr(pos), parU);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_weight(double par) {
    double ret = ChronoEngine_csharpPINVOKE.ChLineCam_Get_weight(swigCPtr, par);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLineCam_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLineCam_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}