//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunctionPosition_line : ChFunctionPosition {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChFunctionPosition_line(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunctionPosition_line obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChFunctionPosition_line(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFunctionPosition_line() : this(ChronoEngine_csharpPINVOKE.new_ChFunctionPosition_line__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionPosition_line(ChFunctionPosition_line other) : this(ChronoEngine_csharpPINVOKE.new_ChFunctionPosition_line__SWIG_1(ChFunctionPosition_line.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChFunctionPosition Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_Clone(swigCPtr);
    ChFunctionPosition_line ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunctionPosition_line(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLine GetLine() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_GetLine(swigCPtr);
    ChLine ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLine(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLine(ChLine mline) {
    ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_SetLine(swigCPtr, ChLine.getCPtr(mline));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction GetSpaceFunction() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_GetSpaceFunction(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSpaceFunction(ChFunction m_funct) {
    ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_SetSpaceFunction(swigCPtr, ChFunction.getCPtr(m_funct));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChVectorD Get_p(double s) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_Get_p(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD Get_p_ds(double s) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_Get_p_ds(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD Get_p_dsds(double s) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_Get_p_dsds(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChFunctionPosition_line_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
