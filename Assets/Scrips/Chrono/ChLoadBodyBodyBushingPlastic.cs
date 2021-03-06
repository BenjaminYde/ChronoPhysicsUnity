//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadBodyBodyBushingPlastic : ChLoadBodyBodyBushingSpherical {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadBodyBodyBushingPlastic(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingPlastic_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadBodyBodyBushingPlastic obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLoadBodyBodyBushingPlastic(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadBodyBodyBushingPlastic(ChBody mbodyA, ChBody mbodyB, ChFrameD abs_application, ChVectorD mstiffness, ChVectorD mdamping, ChVectorD myield) : this(ChronoEngine_csharpPINVOKE.new_ChLoadBodyBodyBushingPlastic(ChBody.getCPtr(mbodyA), ChBody.getCPtr(mbodyB), ChFrameD.getCPtr(abs_application), ChVectorD.getCPtr(mstiffness), ChVectorD.getCPtr(mdamping), ChVectorD.getCPtr(myield)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetYeld(ChVectorD myeld) {
    ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingPlastic_SetYeld(swigCPtr, ChVectorD.getCPtr(myeld));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetYeld() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingPlastic_GetYeld(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPlasticDeformation() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoadBodyBodyBushingPlastic_GetPlasticDeformation(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
