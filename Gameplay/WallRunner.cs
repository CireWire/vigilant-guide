using UnityEngine;

public class WallRunner : MonoBehaviour
{
    public float wallRunForce = 5f;
    public float wallJumpForce = 10f;
    private bool isWallRunning = false;
    private bool isJumping = false;

    private void Update()
    {
        // Check for wall running input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isWallRunning)
            {
                isJumping = true;
                // Apply a force opposite to the wall's normal to perform a wall jump
                GetComponent<Rigidbody2D>().AddForce(-transform.right * wallJumpForce, ForceMode2D.Impulse);
            }
        }
    }

    private void FixedUpdate()
    {
        // Calculate the raycast direction based on the player's orientation
        Vector2 raycastDirection = transform.right;

        // Cast a ray in the wall running direction
        RaycastHit2D hit = Physics2D.Raycast(transform.position, raycastDirection, 1f);

        // Check if the player is touching a wall
        if (hit.collider != null)
        {
            if (!isWallRunning && !isJumping)
            {
                // Start wall running
                isWallRunning = true;
                GetComponent<Rigidbody2D>().gravityScale = 0f;
            }

            // Apply force to simulate wall running
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * wallRunForce);
        }
        else
        {
            // Stop wall running
            isWallRunning = false;
            GetComponent<Rigidbody2D>().gravityScale = 1f;
        }

        // Reset jumping flag
        isJumping = false;
    }
}
