//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunction_Poly345 : ChFunction {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChFunction_Poly345(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChFunction_Poly345_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunction_Poly345 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChFunction_Poly345(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFunction_Poly345() : this(ChronoEngine_csharpPINVOKE.new_ChFunction_Poly345__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction_Poly345(double m_h, double m_end) : this(ChronoEngine_csharpPINVOKE.new_ChFunction_Poly345__SWIG_1(m_h, m_end), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction_Poly345(ChFunction_Poly345 other) : this(ChronoEngine_csharpPINVOKE.new_ChFunction_Poly345__SWIG_2(ChFunction_Poly345.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChFunction.FunctionType Get_Type() {
    ChFunction.FunctionType ret = (ChFunction.FunctionType)ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_Type(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Get_y(double x) {
    double ret = ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_y(swigCPtr, x);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Get_y_dx(double x) {
    double ret = ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_y_dx(swigCPtr, x);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Get_y_dxdx(double x) {
    double ret = ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_y_dxdx(swigCPtr, x);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_end(double m_end) {
    ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Set_end(swigCPtr, m_end);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set_h(double m_h) {
    ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Set_h(swigCPtr, m_h);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_end() {
    double ret = ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_end(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get_h() {
    double ret = ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_h(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Get_Ca_pos() {
    double ret = ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_Ca_pos(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Get_Ca_neg() {
    double ret = ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_Ca_neg(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Get_Cv() {
    double ret = ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Get_Cv(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Estimate_x_range(SWIGTYPE_p_double xmin, SWIGTYPE_p_double xmax) {
    ChronoEngine_csharpPINVOKE.ChFunction_Poly345_Estimate_x_range(swigCPtr, SWIGTYPE_p_double.getCPtr(xmin), SWIGTYPE_p_double.getCPtr(xmax));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChFunction_Poly345_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChFunction_Poly345_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
