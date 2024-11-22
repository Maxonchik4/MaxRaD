using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float jumpForce = 5f;

    private bool isGrounded;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetBool("IsJumping", true);
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Логика для определения, находится ли персонаж на земле (например, используя raycast)
        // ...
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        animator.SetBool("IsJumping", false);
    }
}