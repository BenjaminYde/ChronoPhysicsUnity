//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChCollisionSystem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChCollisionSystem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChCollisionSystem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChCollisionSystem() {
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
          ChronoEngine_csharpPINVOKE.delete_ChCollisionSystem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual ChCollisionSystemType GetType() {
    ChCollisionSystemType ret = (ChCollisionSystemType)ChronoEngine_csharpPINVOKE.ChCollisionSystem_GetType(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Clear() {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_Clear(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Add(ChCollisionModel model) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_Add(swigCPtr, ChCollisionModel.getCPtr(model));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Remove(ChCollisionModel model) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_Remove(swigCPtr, ChCollisionModel.getCPtr(model));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void PreProcess() {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_PreProcess(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Run() {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_Run(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void PostProcess() {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_PostProcess(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void GetBoundingBox(ChVectorD aabb_min, ChVectorD aabb_max) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_GetBoundingBox(swigCPtr, ChVectorD.getCPtr(aabb_min), ChVectorD.getCPtr(aabb_max));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetTimerCollisionBroad() {
    double ret = ChronoEngine_csharpPINVOKE.ChCollisionSystem_GetTimerCollisionBroad(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTimerCollisionNarrow() {
    double ret = ChronoEngine_csharpPINVOKE.ChCollisionSystem_GetTimerCollisionNarrow(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ResetTimers() {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_ResetTimers(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetNumThreads(int nthreads) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_SetNumThreads(swigCPtr, nthreads);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReportContacts(ChContactContainer mcontactcontainer) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_ReportContacts(swigCPtr, ChContactContainer.getCPtr(mcontactcontainer));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReportProximities(ChProximityContainer mproximitycontainer) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_ReportProximities(swigCPtr, ChProximityContainer.getCPtr(mproximitycontainer));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterBroadphaseCallback(BroadphaseCallback callback) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_RegisterBroadphaseCallback(swigCPtr, BroadphaseCallback.getCPtr(callback));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterNarrowphaseCallback(NarrowphaseCallback callback) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_RegisterNarrowphaseCallback(swigCPtr, NarrowphaseCallback.getCPtr(callback));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool RayHit(ChVectorD from, ChVectorD to, ChRayhitResult result) {
    bool ret = ChronoEngine_csharpPINVOKE.ChCollisionSystem_RayHit__SWIG_0(swigCPtr, ChVectorD.getCPtr(from), ChVectorD.getCPtr(to), ChRayhitResult.getCPtr(result));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool RayHit(ChVectorD from, ChVectorD to, ChCollisionModel model, ChRayhitResult result) {
    bool ret = ChronoEngine_csharpPINVOKE.ChCollisionSystem_RayHit__SWIG_1(swigCPtr, ChVectorD.getCPtr(from), ChVectorD.getCPtr(to), ChCollisionModel.getCPtr(model), ChRayhitResult.getCPtr(result));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSystem(ChSystem sys) {
    ChronoEngine_csharpPINVOKE.ChCollisionSystem_SetSystem(swigCPtr, ChSystem.getCPtr(sys));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
