//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChParticlesClones : ChIndexedParticles {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChParticlesClones(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChParticlesClones_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChParticlesClones obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChParticlesClones(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChParticlesClones() : this(corePINVOKE.new_ChParticlesClones__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChParticlesClones(ChParticlesClones other) : this(corePINVOKE.new_ChParticlesClones__SWIG_1(ChParticlesClones.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCollide(bool mcoll) {
    corePINVOKE.ChParticlesClones_SetCollide(swigCPtr, mcoll);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool GetCollide() {
    bool ret = corePINVOKE.ChParticlesClones_GetCollide(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLimitSpeed(bool mlimit) {
    corePINVOKE.ChParticlesClones_SetLimitSpeed(swigCPtr, mlimit);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetLimitSpeed() {
    bool ret = corePINVOKE.ChParticlesClones_GetLimitSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint GetNparticles() {
    uint ret = corePINVOKE.ChParticlesClones_GetNparticles(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChParticleBase GetParticle(uint n) {
    ChParticleBase ret = new ChParticleBase(corePINVOKE.ChParticlesClones_GetParticle(swigCPtr, n), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ResizeNparticles(int newsize) {
    corePINVOKE.ChParticlesClones_ResizeNparticles(swigCPtr, newsize);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddParticle(ChCoordsysD initial_state) {
    corePINVOKE.ChParticlesClones_AddParticle__SWIG_0(swigCPtr, ChCoordsysD.getCPtr(initial_state));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddParticle() {
    corePINVOKE.ChParticlesClones_AddParticle__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaterialSurface(ChMaterialSurface mnewsurf) {
    corePINVOKE.ChParticlesClones_SetMaterialSurface(swigCPtr, ChMaterialSurface.getCPtr(mnewsurf));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChMaterialSurface GetMaterialSurface() {
    global::System.IntPtr cPtr = corePINVOKE.ChParticlesClones_GetMaterialSurface(swigCPtr);
    ChMaterialSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMaterialSurface(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void IntStateGather(uint off_x, ChState x, uint off_v, ChStateDelta v, SWIGTYPE_p_double T) {
    corePINVOKE.ChParticlesClones_IntStateGather(swigCPtr, off_x, ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(v), SWIGTYPE_p_double.getCPtr(T));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatter(uint off_x, ChState x, uint off_v, ChStateDelta v, double T, bool full_update) {
    corePINVOKE.ChParticlesClones_IntStateScatter(swigCPtr, off_x, ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(v), T, full_update);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGatherAcceleration(uint off_a, ChStateDelta a) {
    corePINVOKE.ChParticlesClones_IntStateGatherAcceleration(swigCPtr, off_a, ChStateDelta.getCPtr(a));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterAcceleration(uint off_a, ChStateDelta a) {
    corePINVOKE.ChParticlesClones_IntStateScatterAcceleration(swigCPtr, off_a, ChStateDelta.getCPtr(a));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateIncrement(uint off_x, ChState x_new, ChState x, uint off_v, ChStateDelta Dv) {
    corePINVOKE.ChParticlesClones_IntStateIncrement(swigCPtr, off_x, ChState.getCPtr(x_new), ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(Dv));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_F(uint off, ChVectorDynamicD R, double c) {
    corePINVOKE.ChParticlesClones_IntLoadResidual_F(swigCPtr, off, ChVectorDynamicD.getCPtr(R), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_Mv(uint off, ChVectorDynamicD R, ChVectorDynamicD w, double c) {
    corePINVOKE.ChParticlesClones_IntLoadResidual_Mv(swigCPtr, off, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(w), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntToDescriptor(uint off_v, ChStateDelta v, ChVectorDynamicD R, uint off_L, ChVectorDynamicD L, ChVectorDynamicD Qc) {
    corePINVOKE.ChParticlesClones_IntToDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), ChVectorDynamicD.getCPtr(R), off_L, ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(Qc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntFromDescriptor(uint off_v, ChStateDelta v, uint off_L, ChVectorDynamicD L) {
    corePINVOKE.ChParticlesClones_IntFromDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), off_L, ChVectorDynamicD.getCPtr(L));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbReset() {
    corePINVOKE.ChParticlesClones_VariablesFbReset(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbLoadForces(double factor) {
    corePINVOKE.ChParticlesClones_VariablesFbLoadForces__SWIG_0(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbLoadForces() {
    corePINVOKE.ChParticlesClones_VariablesFbLoadForces__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbLoadSpeed() {
    corePINVOKE.ChParticlesClones_VariablesQbLoadSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbIncrementMq() {
    corePINVOKE.ChParticlesClones_VariablesFbIncrementMq(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbSetSpeed(double step) {
    corePINVOKE.ChParticlesClones_VariablesQbSetSpeed__SWIG_0(swigCPtr, step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbSetSpeed() {
    corePINVOKE.ChParticlesClones_VariablesQbSetSpeed__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbIncrementPosition(double step) {
    corePINVOKE.ChParticlesClones_VariablesQbIncrementPosition(swigCPtr, step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectVariables(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    corePINVOKE.ChParticlesClones_InjectVariables(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetNoSpeedNoAcceleration() {
    corePINVOKE.ChParticlesClones_SetNoSpeedNoAcceleration(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChCollisionModel GetCollisionModel() {
    global::System.IntPtr cPtr = corePINVOKE.ChParticlesClones_GetCollisionModel(swigCPtr);
    ChCollisionModel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChCollisionModel(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SyncCollisionModels() {
    corePINVOKE.ChParticlesClones_SyncCollisionModels(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddCollisionModelsToSystem() {
    corePINVOKE.ChParticlesClones_AddCollisionModelsToSystem(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveCollisionModelsFromSystem() {
    corePINVOKE.ChParticlesClones_RemoveCollisionModelsFromSystem(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void UpdateParticleCollisionModels() {
    corePINVOKE.ChParticlesClones_UpdateParticleCollisionModels(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMass(double newmass) {
    corePINVOKE.ChParticlesClones_SetMass(swigCPtr, newmass);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetMass() {
    double ret = corePINVOKE.ChParticlesClones_GetMass(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetInertia(ChMatrix33D newXInertia) {
    corePINVOKE.ChParticlesClones_SetInertia(swigCPtr, ChMatrix33D.getCPtr(newXInertia));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetInertiaXX(ChVectorD iner) {
    corePINVOKE.ChParticlesClones_SetInertiaXX(swigCPtr, ChVectorD.getCPtr(iner));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetInertiaXX() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChParticlesClones_GetInertiaXX(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetInertiaXY(ChVectorD iner) {
    corePINVOKE.ChParticlesClones_SetInertiaXY(swigCPtr, ChVectorD.getCPtr(iner));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetInertiaXY() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChParticlesClones_GetInertiaXY(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaxSpeed(float m_max_speed) {
    corePINVOKE.ChParticlesClones_SetMaxSpeed(swigCPtr, m_max_speed);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetMaxSpeed() {
    float ret = corePINVOKE.ChParticlesClones_GetMaxSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaxWvel(float m_max_wvel) {
    corePINVOKE.ChParticlesClones_SetMaxWvel(swigCPtr, m_max_wvel);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetMaxWvel() {
    float ret = corePINVOKE.ChParticlesClones_GetMaxWvel(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ClampSpeed() {
    corePINVOKE.ChParticlesClones_ClampSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSleepTime(float m_t) {
    corePINVOKE.ChParticlesClones_SetSleepTime(swigCPtr, m_t);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetSleepTime() {
    float ret = corePINVOKE.ChParticlesClones_GetSleepTime(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSleepMinSpeed(float m_t) {
    corePINVOKE.ChParticlesClones_SetSleepMinSpeed(swigCPtr, m_t);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetSleepMinSpeed() {
    float ret = corePINVOKE.ChParticlesClones_GetSleepMinSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSleepMinWvel(float m_t) {
    corePINVOKE.ChParticlesClones_SetSleepMinWvel(swigCPtr, m_t);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetSleepMinWvel() {
    float ret = corePINVOKE.ChParticlesClones_GetSleepMinWvel(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Update(double mytime, bool update_assets) {
    corePINVOKE.ChParticlesClones_Update__SWIG_0(swigCPtr, mytime, update_assets);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime) {
    corePINVOKE.ChParticlesClones_Update__SWIG_1(swigCPtr, mytime);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(bool update_assets) {
    corePINVOKE.ChParticlesClones_Update__SWIG_2(swigCPtr, update_assets);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update() {
    corePINVOKE.ChParticlesClones_Update__SWIG_3(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    corePINVOKE.ChParticlesClones_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChParticlesClones_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
