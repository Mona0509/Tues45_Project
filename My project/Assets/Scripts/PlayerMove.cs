using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private float tallJumpPow = 10.0f;
    [SerializeField] private float nomalJumpPow = 5.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    private void FixedUpdate()
    {
        // ƒWƒƒƒ“ƒv‚ð‚·‚é
        if (PlayerMoveInput.isTallJump)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x,
                                            tallJumpPow,
                                            rb.linearVelocity.z);
            PlayerMoveInput.isTallJump = false;
        }

        if (PlayerMoveInput.isNomalJump)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x,
                                            nomalJumpPow,
                                            rb.linearVelocity.z);
            PlayerMoveInput.isNomalJump = false;
        }

    }
}
