//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChStressTensorD : ChVoightTensorD {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChStressTensorD(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChStressTensorD_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChStressTensorD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ChronoEngine_csharpPINVOKE.delete_ChStressTensorD(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChStressTensorD() : this(ChronoEngine_csharpPINVOKE.new_ChStressTensorD(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ComputePrincipalStresses(SWIGTYPE_p_double e1, SWIGTYPE_p_double e2, SWIGTYPE_p_double e3) {
    ChronoEngine_csharpPINVOKE.ChStressTensorD_ComputePrincipalStresses(swigCPtr, SWIGTYPE_p_double.getCPtr(e1), SWIGTYPE_p_double.getCPtr(e2), SWIGTYPE_p_double.getCPtr(e3));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ComputePrincipalStressesDirections(SWIGTYPE_p_double e1, SWIGTYPE_p_double e2, SWIGTYPE_p_double e3, ChVectorD dir1, ChVectorD dir2, ChVectorD dir3) {
    ChronoEngine_csharpPINVOKE.ChStressTensorD_ComputePrincipalStressesDirections(swigCPtr, SWIGTYPE_p_double.getCPtr(e1), SWIGTYPE_p_double.getCPtr(e2), SWIGTYPE_p_double.getCPtr(e3), ChVectorD.getCPtr(dir1), ChVectorD.getCPtr(dir2), ChVectorD.getCPtr(dir3));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
