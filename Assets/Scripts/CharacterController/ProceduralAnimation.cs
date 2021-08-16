using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntityRig { }

public class ProceduralAnimationController<RigType> where RigType : IEntityRig
{
    public static EmptyAnimation<RigType> emptyAnim = new EmptyAnimation<RigType>();

    CharacterInputFeed cif;
    RigType targetRig;

    private ProceduralAnimation<RigType> currentAnimation = emptyAnim;

    public void SwitchTo(ProceduralAnimation<RigType> newAnim)
    {
        currentAnimation.OnAnimationEnd();
        currentAnimation = newAnim;
        currentAnimation.OnAnimationStart();
    }

    public ProceduralAnimation<RigType> GetCurrentAnim()
    {
        return currentAnimation;
    }

    public ProceduralAnimationController( CharacterInputFeed cif, RigType targetRig )
    {
        this.targetRig = targetRig;
        this.cif = cif;
        this.currentAnimation = emptyAnim;
    }

    public void Step(float delta)
    {
        currentAnimation.OnAnimationStep(delta);
    }

    public bool Finished()
    {
        return currentAnimation.Finished();
    }
}

public abstract class ProceduralAnimation<RigType>
{
    public abstract void OnAnimationStart();

    public abstract void OnAnimationStep(float delta);

    public abstract void OnAnimationEnd();

    public abstract bool Finished();

    public static void InterpolateTransforms( Transform t1, Transform t2, float t )
    {
        t1.localPosition = Vector3.Lerp(t1.localPosition, t2.localPosition, t);
        t1.localRotation = Quaternion.Lerp(t1.localRotation, t2.localRotation, t);
    }
}

// Animation that does nothing ( null pattern )
public class EmptyAnimation<RigType> : ProceduralAnimation<RigType>
{
    public override void OnAnimationEnd() { }
    public override void OnAnimationStart() { }
    public override void OnAnimationStep(float delta) { }

    public override bool Finished() { return false; }
}