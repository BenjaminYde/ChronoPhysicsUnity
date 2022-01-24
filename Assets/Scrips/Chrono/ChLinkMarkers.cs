//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkMarkers : ChLink {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkMarkers(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLinkMarkers_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkMarkers obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLinkMarkers(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkMarkers_Clone(swigCPtr);
    ChLinkMarkers ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkMarkers(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChMarker GetMarker1() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetMarker1(swigCPtr);
    ChMarker ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMarker(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChMarker GetMarker2() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetMarker2(swigCPtr);
    ChMarker ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMarker(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetUpMarkers(ChMarker mark1, ChMarker mark2) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_SetUpMarkers(swigCPtr, ChMarker.getCPtr(mark1), ChMarker.getCPtr(mark2));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMarkID1(int mid) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_SetMarkID1(swigCPtr, mid);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMarkID2(int mid) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_SetMarkID2(swigCPtr, mid);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetMarkID1() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetMarkID1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetMarkID2() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetMarkID2(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ReferenceMarkers(ChMarker mark1, ChMarker mark2) {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkMarkers_ReferenceMarkers(swigCPtr, ChMarker.getCPtr(mark1), ChMarker.getCPtr(mark2));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Initialize(ChMarker mark1, ChMarker mark2) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_Initialize__SWIG_0(swigCPtr, ChMarker.getCPtr(mark1), ChMarker.getCPtr(mark2));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChBody mbody1, ChBody mbody2, ChCoordsysD mpos) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_Initialize__SWIG_1(swigCPtr, ChBody.getCPtr(mbody1), ChBody.getCPtr(mbody2), ChCoordsysD.getCPtr(mpos));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChBody mbody1, ChBody mbody2, bool pos_are_relative, ChCoordsysD mpos1, ChCoordsysD mpos2) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_Initialize__SWIG_2(swigCPtr, ChBody.getCPtr(mbody1), ChBody.getCPtr(mbody2), pos_are_relative, ChCoordsysD.getCPtr(mpos1), ChCoordsysD.getCPtr(mpos2));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChCoordsysD GetLinkRelativeCoords() {
    ChCoordsysD ret = new ChCoordsysD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetLinkRelativeCoords(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChFrameD GetAssetsFrame(uint nclone) {
    ChFrameD ret = new ChFrameD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetAssetsFrame__SWIG_0(swigCPtr, nclone), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChFrameD GetAssetsFrame() {
    ChFrameD ret = new ChFrameD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetAssetsFrame__SWIG_1(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void UpdateRelMarkerCoords() {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_UpdateRelMarkerCoords(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void UpdateForces(double mytime) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_UpdateForces(swigCPtr, mytime);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime, bool update_assets) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_Update__SWIG_0(swigCPtr, mytime, update_assets);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_Update__SWIG_1(swigCPtr, mytime);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_F(uint off, ChVectorDynamicD R, double c) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_IntLoadResidual_F(swigCPtr, off, ChVectorDynamicD.getCPtr(R), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFbLoadForces(double factor) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_ConstraintsFbLoadForces__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFbLoadForces() {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_ConstraintsFbLoadForces__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChCoordsysD GetRelM() {
    ChCoordsysD ret = new ChCoordsysD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetRelM(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChCoordsysD GetRelM_dt() {
    ChCoordsysD ret = new ChCoordsysD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetRelM_dt(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChCoordsysD GetRelM_dtdt() {
    ChCoordsysD ret = new ChCoordsysD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetRelM_dtdt(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRelAngle() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetRelAngle(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetRelAxis() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetRelAxis(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetRelRotaxis() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetRelRotaxis(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetRelWvel() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetRelWvel(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetRelWacc() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetRelWacc(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetDist() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetDist(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetDist_dt() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetDist_dt(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetC_force() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetC_force(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetC_torque() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkMarkers_GetC_torque(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkMarkers_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
