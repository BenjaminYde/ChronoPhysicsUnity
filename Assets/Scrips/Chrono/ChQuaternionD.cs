//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChQuaternionD : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChQuaternionD(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChQuaternionD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChQuaternionD() {
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
          ChronoEngine_csharpPINVOKE.delete_ChQuaternionD(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChQuaternionD() : this(ChronoEngine_csharpPINVOKE.new_ChQuaternionD__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChQuaternionD(double e0, double e1, double e2, double e3) : this(ChronoEngine_csharpPINVOKE.new_ChQuaternionD__SWIG_1(e0, e1, e2, e3), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChQuaternionD(double s, ChVectorD v) : this(ChronoEngine_csharpPINVOKE.new_ChQuaternionD__SWIG_2(s, ChVectorD.getCPtr(v)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChQuaternionD(ChQuaternionD other) : this(ChronoEngine_csharpPINVOKE.new_ChQuaternionD__SWIG_3(ChQuaternionD.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_double data() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChQuaternionD_data(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set(double e0, double e1, double e2, double e3) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Set__SWIG_0(swigCPtr, e0, e1, e2, e3);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(ChQuaternionD q) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Set__SWIG_1(swigCPtr, ChQuaternionD.getCPtr(q));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(double s) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Set__SWIG_2(swigCPtr, s);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetNull() {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_SetNull(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetUnit() {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_SetUnit(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetScalar(double s) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_SetScalar(swigCPtr, s);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetVector(ChVectorD v) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_SetVector(swigCPtr, ChVectorD.getCPtr(v));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Equals(ChQuaternionD other) {
    bool ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_Equals__SWIG_0(swigCPtr, ChQuaternionD.getCPtr(other));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(ChQuaternionD other, double tol) {
    bool ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_Equals__SWIG_1(swigCPtr, ChQuaternionD.getCPtr(other), tol);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetVector() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_GetVector(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetXaxis() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_GetXaxis(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetYaxis() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_GetYaxis(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetZaxis() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_GetZaxis(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Length() {
    double ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_Length(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Length2() {
    double ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_Length2(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double LengthInf() {
    double ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_LengthInf(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(ChQuaternionD A, ChQuaternionD B) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Add(swigCPtr, ChQuaternionD.getCPtr(A), ChQuaternionD.getCPtr(B));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Sub(ChQuaternionD A, ChQuaternionD B) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Sub(swigCPtr, ChQuaternionD.getCPtr(A), ChQuaternionD.getCPtr(B));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Cross(ChQuaternionD qa, ChQuaternionD qb) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Cross(swigCPtr, ChQuaternionD.getCPtr(qa), ChQuaternionD.getCPtr(qb));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Dot(ChQuaternionD B) {
    double ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_Dot(swigCPtr, ChQuaternionD.getCPtr(B));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Mul(ChQuaternionD A, double s) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Mul(swigCPtr, ChQuaternionD.getCPtr(A), s);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Scale(double s) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Scale(swigCPtr, s);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Normalize() {
    bool ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_Normalize(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChQuaternionD GetNormalized() {
    ChQuaternionD ret = new ChQuaternionD(ChronoEngine_csharpPINVOKE.ChQuaternionD_GetNormalized(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Conjugate(ChQuaternionD A) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Conjugate__SWIG_0(swigCPtr, ChQuaternionD.getCPtr(A));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Conjugate() {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Conjugate__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChQuaternionD GetConjugate() {
    ChQuaternionD ret = new ChQuaternionD(ChronoEngine_csharpPINVOKE.ChQuaternionD_GetConjugate(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChQuaternionD GetInverse() {
    ChQuaternionD ret = new ChQuaternionD(ChronoEngine_csharpPINVOKE.ChQuaternionD_GetInverse(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD Rotate(ChVectorD A) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_Rotate(swigCPtr, ChVectorD.getCPtr(A)), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD RotateBack(ChVectorD A) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_RotateBack(swigCPtr, ChVectorD.getCPtr(A)), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Q_from_Rotv(ChVectorD angle_axis) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_from_Rotv(swigCPtr, ChVectorD.getCPtr(angle_axis));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD Q_to_Rotv() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_to_Rotv(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Q_from_AngAxis(double angle, ChVectorD axis) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_from_AngAxis(swigCPtr, angle, ChVectorD.getCPtr(axis));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Q_from_AngX(double angleX) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_from_AngX(swigCPtr, angleX);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Q_from_AngY(double angleY) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_from_AngY(swigCPtr, angleY);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Q_from_AngZ(double angleZ) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_from_AngZ(swigCPtr, angleZ);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Q_to_AngAxis(SWIGTYPE_p_double a_angle, ChVectorD a_axis) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_to_AngAxis(swigCPtr, SWIGTYPE_p_double.getCPtr(a_angle), ChVectorD.getCPtr(a_axis));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Q_from_NasaAngles(ChVectorD ang) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_from_NasaAngles(swigCPtr, ChVectorD.getCPtr(ang));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD Q_to_NasaAngles() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_to_NasaAngles(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Q_from_Euler123(ChVectorD ang) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_from_Euler123(swigCPtr, ChVectorD.getCPtr(ang));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD Q_to_Euler123() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChQuaternionD_Q_to_Euler123(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Qdt_from_Wabs(ChVectorD w, ChQuaternionD q) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Qdt_from_Wabs(swigCPtr, ChVectorD.getCPtr(w), ChQuaternionD.getCPtr(q));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Qdt_from_Wrel(ChVectorD w, ChQuaternionD q) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Qdt_from_Wrel(swigCPtr, ChVectorD.getCPtr(w), ChQuaternionD.getCPtr(q));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Qdt_to_Wabs(ChVectorD w, ChQuaternionD q) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Qdt_to_Wabs(swigCPtr, ChVectorD.getCPtr(w), ChQuaternionD.getCPtr(q));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Qdt_to_Wrel(ChVectorD w, ChQuaternionD q) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Qdt_to_Wrel(swigCPtr, ChVectorD.getCPtr(w), ChQuaternionD.getCPtr(q));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Qdtdt_from_Aabs(ChVectorD a, ChQuaternionD q, ChQuaternionD q_dt) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Qdtdt_from_Aabs(swigCPtr, ChVectorD.getCPtr(a), ChQuaternionD.getCPtr(q), ChQuaternionD.getCPtr(q_dt));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Qdtdt_from_Arel(ChVectorD a, ChQuaternionD q, ChQuaternionD q_dt) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Qdtdt_from_Arel(swigCPtr, ChVectorD.getCPtr(a), ChQuaternionD.getCPtr(q), ChQuaternionD.getCPtr(q_dt));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Qdt_from_AngAxis(ChQuaternionD q, double angle_dt, ChVectorD axis) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Qdt_from_AngAxis(swigCPtr, ChQuaternionD.getCPtr(q), angle_dt, ChVectorD.getCPtr(axis));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Qdtdt_from_AngAxis(ChQuaternionD q, ChQuaternionD q_dt, double angle_dtdt, ChVectorD axis) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_Qdtdt_from_AngAxis(swigCPtr, ChQuaternionD.getCPtr(q), ChQuaternionD.getCPtr(q_dt), angle_dtdt, ChVectorD.getCPtr(axis));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ImmQ_complete(ChVectorD qimm) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_ImmQ_complete(swigCPtr, ChVectorD.getCPtr(qimm));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ImmQ_dt_complete(ChQuaternionD q, ChVectorD qimm_dt) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_ImmQ_dt_complete(swigCPtr, ChQuaternionD.getCPtr(q), ChVectorD.getCPtr(qimm_dt));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ImmQ_dtdt_complete(ChQuaternionD q, ChQuaternionD qdt, ChVectorD qimm_dtdt) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_ImmQ_dtdt_complete(swigCPtr, ChQuaternionD.getCPtr(q), ChQuaternionD.getCPtr(qdt), ChVectorD.getCPtr(qimm_dtdt));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChQuaternionD_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double e0 {
    set {
      ChronoEngine_csharpPINVOKE.ChQuaternionD_e0_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_e0_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double e1 {
    set {
      ChronoEngine_csharpPINVOKE.ChQuaternionD_e1_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_e1_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double e2 {
    set {
      ChronoEngine_csharpPINVOKE.ChQuaternionD_e2_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_e2_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double e3 {
    set {
      ChronoEngine_csharpPINVOKE.ChQuaternionD_e3_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = ChronoEngine_csharpPINVOKE.ChQuaternionD_e3_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
