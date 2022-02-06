namespace ChronoUnity
{
    public enum NscSolverType
    {
        Iterative_VI_APGD, // higher precision
        Iterative_VI_BB, // higher precision
        Iterative_VI_PSOR, // faster speed, lower precision
        Iterative_VI_PJACOBI,
        Iterative_LS_BICGSTAB,
        Iterative_LS_GMRES, // for problems that involve a stiffness matrix
        Iterative_LS_MINRES, // for problems that involve a stiffness matrix
        //Direct_LS_SPARSELU, // this one fails
        Direct_LS_SPARSEQR
    }
}