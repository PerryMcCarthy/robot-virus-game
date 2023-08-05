using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rAnimationController : MonoBehaviour
{
    private Animator anim;
    private bool accept_input = true;

    public AnimationClip OrcWalkAnimClip;
    public AnimationClip StrafeAnimClip;
    public AnimationClip RobotHipHopAnimClip;
    public AnimationClip TauntAnimClip;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();

        if(OrcWalkAnimClip != null) {
            AddInputBlockingAnimEndCallback(OrcWalkAnimClip);
            AddInputBlockingAnimEndCallback(StrafeAnimClip);
            AddInputBlockingAnimEndCallback(RobotHipHopAnimClip);
            AddInputBlockingAnimEndCallback(TauntAnimClip);
        }
    }

    private void AddInputBlockingAnimEndCallback(AnimationClip clip){
        AnimationEvent animDoneEvent = new AnimationEvent();
        animDoneEvent.time = clip.length;
        animDoneEvent.functionName = "OnInputBlockingAnimationDone";
        clip.AddEvent(animDoneEvent); 
    }

    // Update is called once per frame
    void Update()
    {
        if (accept_input){
            HandleInput();
        }
    }

        private void OnInputBlockingAnimationDone(){
        accept_input = true;
    }
    private void HandleInput()
    {
        if(Input.GetKey(KeyCode.W)) {
           anim.SetTrigger("OrcWalk");
            accept_input = false;
        }
        if(Input.GetKey(KeyCode.Q)) {
           anim.SetTrigger("Strafe");
            accept_input = false;
        }
        if(Input.GetKey(KeyCode.H)) {
           anim.SetTrigger("RobotHipHop");
            accept_input = false;
        }
        
        if(Input.GetKey(KeyCode.T)) {
           anim.SetTrigger("Taunt");
            accept_input = false;
        }
    }
}
