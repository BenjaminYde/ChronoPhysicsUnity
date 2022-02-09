//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChContinuumDistribution : ChDistribution {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChContinuumDistribution(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChContinuumDistribution_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChContinuumDistribution obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChContinuumDistribution(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChContinuumDistribution(ChVectorDynamicD mx, ChVectorDynamicD my) : this(corePINVOKE.new_ChContinuumDistribution(ChVectorDynamicD.getCPtr(mx), ChVectorDynamicD.getCPtr(my)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetRandom() {
    double ret = corePINVOKE.ChContinuumDistribution_GetRandom(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD GetProbabilityXpoints() {
    ChVectorDynamicD ret = new ChVectorDynamicD(corePINVOKE.ChContinuumDistribution_GetProbabilityXpoints(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD GetProbabilityYpoints() {
    ChVectorDynamicD ret = new ChVectorDynamicD(corePINVOKE.ChContinuumDistribution_GetProbabilityYpoints(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD GetProbabilityCDFcumulativeX() {
    ChVectorDynamicD ret = new ChVectorDynamicD(corePINVOKE.ChContinuumDistribution_GetProbabilityCDFcumulativeX(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD GetProbabilityCDFcumulativeY() {
    ChVectorDynamicD ret = new ChVectorDynamicD(corePINVOKE.ChContinuumDistribution_GetProbabilityCDFcumulativeY(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
