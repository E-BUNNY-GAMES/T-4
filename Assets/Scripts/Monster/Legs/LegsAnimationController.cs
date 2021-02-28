using UnityEngine;

namespace DefaultNamespace.Monster.Legs
{
    public class LegsAnimationController : MonoBehaviour
    {
        [SerializeField] private Animator animator;


        
        public void ActivateMoveAnimation()
        {
            animator.SetBool("Move", true);
        }

        public void ActivateStayAnimation()
        {
            animator.SetBool("Move", false);    
        }

        public void ActivateStomping()
        {
            animator.SetTrigger("stomping");
        }
        
    }
    
    
}