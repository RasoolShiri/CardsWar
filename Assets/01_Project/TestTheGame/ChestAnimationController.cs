using System.Collections;
using UnityEngine;

public class ChestAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void PlayOpenAnimation(System.Action onComplete)
    {
        animator.SetTrigger("Open");
        StartCoroutine(WaitAndInvoke(onComplete, 1.2f)); // duration of animation
    }

    private IEnumerator WaitAndInvoke(System.Action callback, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        callback?.Invoke();
    }
}