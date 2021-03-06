//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChBodyAuxRef : ChBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChBodyAuxRef(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChBodyAuxRef_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChBodyAuxRef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChBodyAuxRef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChBodyAuxRef(ChCollisionSystemType collision_type) : this(ChronoEngine_csharpPINVOKE.new_ChBodyAuxRef__SWIG_0((int)collision_type), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyAuxRef() : this(ChronoEngine_csharpPINVOKE.new_ChBodyAuxRef__SWIG_1(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyAuxRef(ChCollisionModel new_coll_model) : this(ChronoEngine_csharpPINVOKE.new_ChBodyAuxRef__SWIG_2(ChCollisionModel.getCPtr(new_coll_model)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyAuxRef(ChBodyAuxRef other) : this(ChronoEngine_csharpPINVOKE.new_ChBodyAuxRef__SWIG_3(ChBodyAuxRef.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChBodyAuxRef_Clone(swigCPtr);
    ChBodyAuxRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBodyAuxRef(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFrame_REF_to_abs(ChFrameD mfra) {
    ChronoEngine_csharpPINVOKE.ChBodyAuxRef_SetFrame_REF_to_abs(swigCPtr, ChFrameD.getCPtr(mfra));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChFrameMovingD GetFrame_REF_to_abs() {
    ChFrameMovingD ret = new ChFrameMovingD(ChronoEngine_csharpPINVOKE.ChBodyAuxRef_GetFrame_REF_to_abs(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFrame_COG_to_REF(ChFrameD mloc) {
    ChronoEngine_csharpPINVOKE.ChBodyAuxRef_SetFrame_COG_to_REF(swigCPtr, ChFrameD.getCPtr(mloc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFrameD GetFrame_COG_to_REF() {
    ChFrameD ret = new ChFrameD(ChronoEngine_csharpPINVOKE.ChBodyAuxRef_GetFrame_COG_to_REF(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFrame_REF_to_COG(ChFrameD mloc) {
    ChronoEngine_csharpPINVOKE.ChBodyAuxRef_SetFrame_REF_to_COG(swigCPtr, ChFrameD.getCPtr(mloc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFrameD GetFrame_REF_to_COG() {
    ChFrameD ret = new ChFrameD(ChronoEngine_csharpPINVOKE.ChBodyAuxRef_GetFrame_REF_to_COG(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Update(bool update_assets) {
    ChronoEngine_csharpPINVOKE.ChBodyAuxRef_Update__SWIG_0(swigCPtr, update_assets);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update() {
    ChronoEngine_csharpPINVOKE.ChBodyAuxRef_Update__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChBodyAuxRef_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChBodyAuxRef_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
