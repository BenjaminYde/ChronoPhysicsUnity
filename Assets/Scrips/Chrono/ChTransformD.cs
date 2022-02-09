//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTransformD : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChTransformD(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTransformD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChTransformD() {
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
          corePINVOKE.delete_ChTransformD(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static ChVectorD TransformParentToLocal(ChVectorD parent, ChVectorD origin, ChMatrix33D alignment) {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChTransformD_TransformParentToLocal__SWIG_0(ChVectorD.getCPtr(parent), ChVectorD.getCPtr(origin), ChMatrix33D.getCPtr(alignment)), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ChVectorD TransformLocalToParent(ChVectorD local, ChVectorD origin, ChMatrix33D alignment) {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChTransformD_TransformLocalToParent__SWIG_0(ChVectorD.getCPtr(local), ChVectorD.getCPtr(origin), ChMatrix33D.getCPtr(alignment)), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ChVectorD TransformParentToLocal(ChVectorD parent, ChVectorD origin, ChQuaternionD alignment) {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChTransformD_TransformParentToLocal__SWIG_1(ChVectorD.getCPtr(parent), ChVectorD.getCPtr(origin), ChQuaternionD.getCPtr(alignment)), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ChVectorD TransformLocalToParent(ChVectorD local, ChVectorD origin, ChQuaternionD alignment) {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChTransformD_TransformLocalToParent__SWIG_1(ChVectorD.getCPtr(local), ChVectorD.getCPtr(origin), ChQuaternionD.getCPtr(alignment)), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChTransformD() : this(corePINVOKE.new_ChTransformD(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
