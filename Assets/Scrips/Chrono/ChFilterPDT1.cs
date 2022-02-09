//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFilterPDT1 : ChAnalogueFilter {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChFilterPDT1(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChFilterPDT1_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFilterPDT1 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          corePINVOKE.delete_ChFilterPDT1(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFilterPDT1() : this(corePINVOKE.new_ChFilterPDT1__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFilterPDT1(double step, double Td1, double T1, double Kp) : this(corePINVOKE.new_ChFilterPDT1__SWIG_1(step, Td1, T1, Kp), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFilterPDT1(double step, double Td1, double T1) : this(corePINVOKE.new_ChFilterPDT1__SWIG_2(step, Td1, T1), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFilterPDT1(double step, double Td1) : this(corePINVOKE.new_ChFilterPDT1__SWIG_3(step, Td1), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFilterPDT1(double step) : this(corePINVOKE.new_ChFilterPDT1__SWIG_4(step), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Reset() {
    corePINVOKE.ChFilterPDT1_Reset(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Config(double step, double Td1, double T1, double Kp) {
    corePINVOKE.ChFilterPDT1_Config__SWIG_0(swigCPtr, step, Td1, T1, Kp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Config(double step, double Td1, double T1) {
    corePINVOKE.ChFilterPDT1_Config__SWIG_1(swigCPtr, step, Td1, T1);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Config(double step, double Td1) {
    corePINVOKE.ChFilterPDT1_Config__SWIG_2(swigCPtr, step, Td1);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Config(double step) {
    corePINVOKE.ChFilterPDT1_Config__SWIG_3(swigCPtr, step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double Filter(double u) {
    double ret = corePINVOKE.ChFilterPDT1_Filter(swigCPtr, u);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
