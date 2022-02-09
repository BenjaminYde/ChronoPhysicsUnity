//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChParticleProcessEventMassDistribution : ChParticleProcessEvent {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChParticleProcessEventMassDistribution(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChParticleProcessEventMassDistribution_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChParticleProcessEventMassDistribution obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChParticleProcessEventMassDistribution(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChParticleProcessEventMassDistribution(int u_sects, int v_sects) : this(corePINVOKE.new_ChParticleProcessEventMassDistribution__SWIG_0(u_sects, v_sects), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChParticleProcessEventMassDistribution(int u_sects) : this(corePINVOKE.new_ChParticleProcessEventMassDistribution__SWIG_1(u_sects), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChParticleProcessEventMassDistribution() : this(corePINVOKE.new_ChParticleProcessEventMassDistribution__SWIG_2(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ParticleProcessEvent(ChBody mbody, ChSystem msystem, ChParticleEventTrigger mprocessor) {
    corePINVOKE.ChParticleProcessEventMassDistribution_ParticleProcessEvent(swigCPtr, ChBody.getCPtr(mbody), ChSystem.getCPtr(msystem), ChParticleEventTrigger.getCPtr(mprocessor));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChMatrixDynamicD mmass {
    set {
      corePINVOKE.ChParticleProcessEventMassDistribution_mmass_set(swigCPtr, ChMatrixDynamicD.getCPtr(value));
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = corePINVOKE.ChParticleProcessEventMassDistribution_mmass_get(swigCPtr);
      ChMatrixDynamicD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMatrixDynamicD(cPtr, false);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
