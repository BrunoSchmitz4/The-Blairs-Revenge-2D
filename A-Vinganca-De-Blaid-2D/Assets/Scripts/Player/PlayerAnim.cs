using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator animator;
    private IsGroundedChecker groundedChecker;

    private void Awake()
    {
        // We're using getComponent 'cause we'll connect it script on to player's gameComponent.
        // se fossemos atrelando o script à outro lugar, não poderíamos usar o getComponent
        animator = GetComponent<Animator>();
        groundedChecker = GetComponent<IsGroundedChecker>();
    }

    private void Update()
    {
        bool isMoving = GameManager.Instance.InputManager.Movement != 0;
        animator.SetBool("isMoving", isMoving);
        animator.SetBool("isJumping", !groundedChecker.IsGrounded());
        animator.SetBool("isMoving", isMoving);
    }
}
