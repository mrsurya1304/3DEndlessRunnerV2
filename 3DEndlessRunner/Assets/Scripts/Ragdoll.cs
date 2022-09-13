using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using CMF;

public class Ragdoll : MonoBehaviour
{
    private Collider[] colliders;
    private Rigidbody[] rigidbodies;

    private Rigidbody charRigidBody;
    private Collider charCollider;
    private Animator charAnimator;
    private SimpleSampleCharacterControl controls;

    public GameObject ragdollRoot;
    
    // Start is called before the first frame update
    void Start()
    {
        charRigidBody = GetComponent<Rigidbody>();
        charCollider = GetComponent<CapsuleCollider>();
        charAnimator = GetComponent<Animator>();
        controls = GetComponent<SimpleSampleCharacterControl>();

        colliders = ragdollRoot.GetComponentsInChildren<Collider>();
        rigidbodies = ragdollRoot.GetComponentsInChildren<Rigidbody>();
        
        SetRagdollState(false);

    }
    //A Ragdoll is used for the death animation
    //The below method activates and deactivates the ragdoll when the game is played
    public void SetRagdollState(bool state)
    {
        charRigidBody.isKinematic = state;
        charCollider.enabled = !state;
        charAnimator.enabled = !state;
        controls.enabled = !state;

        foreach(Collider collider in colliders)
        {
            collider.enabled = state;
        }

        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = !state;
        }

    }
}
