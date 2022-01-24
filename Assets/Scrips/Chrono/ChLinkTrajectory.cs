//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkTrajectory : ChLinkLockLock {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkTrajectory(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLinkTrajectory_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkTrajectory obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLinkTrajectory(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkTrajectory() : this(ChronoEngine_csharpPINVOKE.new_ChLinkTrajectory__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkTrajectory(ChLinkTrajectory other) : this(ChronoEngine_csharpPINVOKE.new_ChLinkTrajectory__SWIG_1(ChLinkTrajectory.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkTrajectory_Clone(swigCPtr);
    ChLinkTrajectory ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkTrajectory(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFunction Get_space_fx() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkTrajectory_Get_space_fx(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_space_fx(ChFunction m_funct) {
    ChronoEngine_csharpPINVOKE.ChLinkTrajectory_Set_space_fx(swigCPtr, ChFunction.getCPtr(m_funct));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set_modulo_one_fx(bool mmod) {
    ChronoEngine_csharpPINVOKE.ChLinkTrajectory_Set_modulo_one_fx(swigCPtr, mmod);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLine Get_trajectory_line() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkTrajectory_Get_trajectory_line(swigCPtr);
    ChLine ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLine(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_trajectory_line(ChLine mline) {
    ChronoEngine_csharpPINVOKE.ChLinkTrajectory_Set_trajectory_line(swigCPtr, ChLine.getCPtr(mline));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBody mbody1, ChBody mbody2, ChVectorD mpos1, ChLine mline) {
    ChronoEngine_csharpPINVOKE.ChLinkTrajectory_Initialize(swigCPtr, ChBody.getCPtr(mbody1), ChBody.getCPtr(mbody2), ChVectorD.getCPtr(mpos1), ChLine.getCPtr(mline));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void UpdateTime(double mytime) {
    ChronoEngine_csharpPINVOKE.ChLinkTrajectory_UpdateTime(swigCPtr, mytime);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkTrajectory_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkTrajectory_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
