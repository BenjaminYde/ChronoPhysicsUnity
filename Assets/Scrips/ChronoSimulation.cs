using UnityEngine;

public class ChronoSimulation : MonoBehaviour
{
    // .. FIELDS
    
    private ChSystemNSC system = null;
    private ChBody bodyBoxGround = null;
    private ChBody bodyBoxFalling = null;
    
    // .. INITIALIZATION

    void Start()
    {
        system = new ChSystemNSC();
        system.SetChTime(0);

        var boxMaterial = new ChMaterialSurfaceNSC();
        boxMaterial.SetFriction(0.3f);
        boxMaterial.SetCompliance(0);

        // following version is NOT working!
        /*bodyBoxGround = new ChBodyEasyBox(10,0.5,10,1);
        bodyBoxGround.SetBodyFixed(true);
        bodyBoxGround.SetPos(new ChVectorD(0, 0, 0));
        bodyBoxGround.SetCollide(true);
        system.AddBody(bodyBoxGround);

        bodyBoxFalling = new ChBodyEasyBox(1,1,1,1);
        bodyBoxFalling.SetPos(new ChVectorD(0,3,0));
        bodyBoxFalling.SetCollide(true);
        system.AddBody(bodyBoxFalling);*/
        
        // following version is working!
        bodyBoxGround = new ChBodyEasyBox(10,0.5,10,1, boxMaterial, ChCollisionSystemType.CHRONO);
        bodyBoxGround.SetBodyFixed(true);
        bodyBoxGround.SetPos(new ChVectorD(0, 0, 0));
        bodyBoxGround.SetCollide(true);
        system.AddBody(bodyBoxGround);

        bodyBoxFalling = new ChBodyEasyBox(1,1,1,1, boxMaterial, ChCollisionSystemType.CHRONO);
        bodyBoxFalling.SetPos(new ChVectorD(0,3,0));
        bodyBoxFalling.SetCollide(true);
        system.AddBody(bodyBoxFalling);
        
        // following version is working!
        /*bodyBoxGround = new ChBody();
        bodyBoxGround.GetCollisionModel().AddBox(boxMaterial, 10,0.25,10);
        bodyBoxGround.SetBodyFixed(true);
        bodyBoxGround.SetPos(new ChVectorD(0, 0, 0));
        bodyBoxGround.SetCollide(true);
        system.AddBody(bodyBoxGround);

        bodyBoxFalling = new ChBody();
        bodyBoxFalling.GetCollisionModel().AddBox(boxMaterial, 0.5,0.5,0.5);
        bodyBoxFalling.SetPos(new ChVectorD(0,3,0));
        bodyBoxFalling.SetCollide(true);
        system.AddBody(bodyBoxFalling);*/
    }

    // .. UPDATE
    
    private void FixedUpdate()  
    {
        system.DoStepDynamics(0.01);
    }

    // .. DEBUG
    
    private void OnDrawGizmos()
    {
        if (!Application.isPlaying)
            return;
        
        // ground
        ChVectorD chPosGround = bodyBoxGround.GetPos();
        Vector3 posGround = new Vector3((float)chPosGround.x, (float)chPosGround.y, (float)chPosGround.z);
        
        Gizmos.DrawCube(posGround, new Vector3(10,0.5f,10));
        
        // falling box
        ChVectorD chPosBoxFalling = bodyBoxFalling.GetPos();
        Vector3 posBoxFalling = new Vector3((float)chPosBoxFalling.x, (float)chPosBoxFalling.y, (float)chPosBoxFalling.z);

        Gizmos.color = Color.red;
        Gizmos.DrawCube(posBoxFalling, Vector3.one);
    }
}