using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[System.Serializable, GeneratePropertyBag]
[NodeDescription(
    name: "Animation Crossfade", 
    story: "Crossfade in [Time] on [Animator] to [StateName]", 
    category: "Action/Animation", 
    id: "1bb21b29599fd44e3458438912a9751a")]
public partial class AnimationCrossfadeAction : Action {
    [SerializeReference] public BlackboardVariable<float> Time;
    [SerializeReference] public BlackboardVariable<Animator> Animator;
    [SerializeReference] public BlackboardVariable<string> StateName;
    [SerializeReference] public BlackboardVariable<bool> CanTransitionToSelf;

    protected override Status OnStart() {
        if(ReferenceEquals(Animator.Value, null) || ReferenceEquals(StateName.Value, string.Empty)) {
            Debug.LogError("Animator or StateName is not set.");
            return Status.Failure;
        }
        
        if (!CanTransitionToSelf.Value && Animator.Value.GetCurrentAnimatorStateInfo(0).IsName(StateName.Value)) {
            return Status.Success;
        }
        
        Animator.Value.CrossFade(StateName.Value, Time.Value);
        return Status.Success;
    }
}