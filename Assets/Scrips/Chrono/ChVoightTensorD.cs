//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChVoightTensorD : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChVoightTensorD(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChVoightTensorD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChVoightTensorD() {
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
          ChronoEngine_csharpPINVOKE.delete_ChVoightTensorD(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChVoightTensorD() : this(ChronoEngine_csharpPINVOKE.new_ChVoightTensorD(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetVolumetricPart() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetVolumetricPart(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetDeviatoricPart(ChVoightTensorD mdeviatoric) {
    ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetDeviatoricPart(swigCPtr, ChVoightTensorD.getCPtr(mdeviatoric));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetInvariant_I1() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetInvariant_I1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInvariant_I2() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetInvariant_I2(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInvariant_I3() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetInvariant_I3(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInvariant_J1() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetInvariant_J1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInvariant_J2() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetInvariant_J2(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInvariant_J3() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetInvariant_J3(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Rotate(SWIGTYPE_p_ChMatrix33T_double_t Rot) {
    ChronoEngine_csharpPINVOKE.ChVoightTensorD_Rotate(swigCPtr, SWIGTYPE_p_ChMatrix33T_double_t.getCPtr(Rot));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ComputeEigenvalues(SWIGTYPE_p_double e1, SWIGTYPE_p_double e2, SWIGTYPE_p_double e3) {
    ChronoEngine_csharpPINVOKE.ChVoightTensorD_ComputeEigenvalues(swigCPtr, SWIGTYPE_p_double.getCPtr(e1), SWIGTYPE_p_double.getCPtr(e2), SWIGTYPE_p_double.getCPtr(e3));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ComputeEigenvectors(SWIGTYPE_p_double eigval1, SWIGTYPE_p_double eigval2, SWIGTYPE_p_double eigval3, ChVectorD eigvector1, ChVectorD eigvector2, ChVectorD eigvector3) {
    ChronoEngine_csharpPINVOKE.ChVoightTensorD_ComputeEigenvectors(swigCPtr, SWIGTYPE_p_double.getCPtr(eigval1), SWIGTYPE_p_double.getCPtr(eigval2), SWIGTYPE_p_double.getCPtr(eigval3), ChVectorD.getCPtr(eigvector1), ChVectorD.getCPtr(eigvector2), ChVectorD.getCPtr(eigvector3));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetEquivalentVonMises() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetEquivalentVonMises(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetEquivalentMeanHydrostatic() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetEquivalentMeanHydrostatic(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetEquivalentOctahedralNormal() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetEquivalentOctahedralNormal(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetEquivalentOctahedralDeviatoric() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_GetEquivalentOctahedralDeviatoric(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double XX() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_XX(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double YY() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_YY(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ZZ() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_ZZ(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double XY() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_XY(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double XZ() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_XZ(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double YZ() {
    double ret = ChronoEngine_csharpPINVOKE.ChVoightTensorD_YZ(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
