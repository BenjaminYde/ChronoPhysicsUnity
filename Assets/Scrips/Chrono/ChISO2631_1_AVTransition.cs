//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChISO2631_1_AVTransition : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChISO2631_1_AVTransition(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChISO2631_1_AVTransition obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChISO2631_1_AVTransition() {
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
          ChronoEngine_csharpPINVOKE.delete_ChISO2631_1_AVTransition(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChISO2631_1_AVTransition() : this(ChronoEngine_csharpPINVOKE.new_ChISO2631_1_AVTransition__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChISO2631_1_AVTransition(double step, double f4, double Q4) : this(ChronoEngine_csharpPINVOKE.new_ChISO2631_1_AVTransition__SWIG_1(step, f4, Q4), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChISO2631_1_AVTransition(double step, double f3, double f4, double Q4) : this(ChronoEngine_csharpPINVOKE.new_ChISO2631_1_AVTransition__SWIG_2(step, f3, f4, Q4), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Config(double step, double f4, double Q4) {
    ChronoEngine_csharpPINVOKE.ChISO2631_1_AVTransition_Config__SWIG_0(swigCPtr, step, f4, Q4);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Config(double step, double f3, double f4, double Q4) {
    ChronoEngine_csharpPINVOKE.ChISO2631_1_AVTransition_Config__SWIG_1(swigCPtr, step, f3, f4, Q4);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reset() {
    ChronoEngine_csharpPINVOKE.ChISO2631_1_AVTransition_Reset(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Filter(double u) {
    double ret = ChronoEngine_csharpPINVOKE.ChISO2631_1_AVTransition_Filter(swigCPtr, u);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
