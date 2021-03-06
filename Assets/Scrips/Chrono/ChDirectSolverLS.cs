//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChDirectSolverLS : ChSolverLS {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChDirectSolverLS(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChDirectSolverLS_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChDirectSolverLS obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChDirectSolverLS(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public void LockSparsityPattern(bool val) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_LockSparsityPattern(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UseSparsityPatternLearner(bool val) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_UseSparsityPatternLearner(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ForceSparsityPatternUpdate() {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_ForceSparsityPatternUpdate(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSparsityEstimate(double sparsity) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_SetSparsityEstimate(swigCPtr, sparsity);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetMatrixSymmetryType(ChDirectSolverLS.MatrixSymmetryType symmetry) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_SetMatrixSymmetryType(swigCPtr, (int)symmetry);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UsePermutationVector(bool val) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_UsePermutationVector(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LeverageRhsSparsity(bool val) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_LeverageRhsSparsity(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void EnableNullPivotDetection(bool val, double threshold) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_EnableNullPivotDetection__SWIG_0(swigCPtr, val, threshold);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void EnableNullPivotDetection(bool val) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_EnableNullPivotDetection__SWIG_1(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ResetTimers() {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_ResetTimers(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTimeSolve_Assembly() {
    double ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_GetTimeSolve_Assembly(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimeSolve_SolverCall() {
    double ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_GetTimeSolve_SolverCall(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimeSetup_Assembly() {
    double ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_GetTimeSetup_Assembly(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimeSetup_SolverCall() {
    double ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_GetTimeSetup_SolverCall(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumSetupCalls() {
    int ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_GetNumSetupCalls(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumSolveCalls() {
    int ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_GetNumSolveCalls(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Eigen__SparseMatrixT_double_Eigen__RowMajor_int_t GetMatrix() {
    SWIGTYPE_p_Eigen__SparseMatrixT_double_Eigen__RowMajor_int_t ret = new SWIGTYPE_p_Eigen__SparseMatrixT_double_Eigen__RowMajor_int_t(ChronoEngine_csharpPINVOKE.ChDirectSolverLS_GetMatrix(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Eigen__SparseMatrixT_double_Eigen__RowMajor_int_t A() {
    SWIGTYPE_p_Eigen__SparseMatrixT_double_Eigen__RowMajor_int_t ret = new SWIGTYPE_p_Eigen__SparseMatrixT_double_Eigen__RowMajor_int_t(ChronoEngine_csharpPINVOKE.ChDirectSolverLS_A(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD x() {
    ChVectorDynamicD ret = new ChVectorDynamicD(ChronoEngine_csharpPINVOKE.ChDirectSolverLS_x(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD b() {
    ChVectorDynamicD ret = new ChVectorDynamicD(ChronoEngine_csharpPINVOKE.ChDirectSolverLS_b(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Setup(SWIGTYPE_p_ChSystemDescriptor sysd) {
    bool ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_Setup(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(sysd));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Solve(SWIGTYPE_p_ChSystemDescriptor sysd) {
    double ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_Solve(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(sysd));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool SetupCurrent() {
    bool ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_SetupCurrent(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double SolveCurrent() {
    double ret = ChronoEngine_csharpPINVOKE.ChDirectSolverLS_SolveCurrent(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChDirectSolverLS_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum MatrixSymmetryType {
    GENERAL,
    SYMMETRIC_POSDEF,
    SYMMETRIC_INDEF,
    STRUCTURAL_SYMMETRIC
  }

}
