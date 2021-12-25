using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VikingController : MonoBehaviour
{
    public int MovingDirection = 0;
    public float direction = 0;
    public float JumpingForce;
    public float distToGround;
    Rigidbody rb;
    CapsuleCollider collider;
    bool run = false;
    Animator animator;

    [SerializeField] float movingSpeed = 10f;

    bool isGround()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.001f);
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collider = GetComponent<CapsuleCollider>();
        distToGround = collider.bounds.extents.y;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.y < -10)
        {
            SceneManager.LoadScene(2);
        }

        run = false;

        if (Input.GetKey(KeyCode.W))
        {
            if (MovingDirection == 0)
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
            else if (MovingDirection == 1)
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
            else if (MovingDirection == 2)
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
            else if (MovingDirection == 3)
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
            run = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGround())
        {
            rb.AddForce(JumpingForce * Vector3.up);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            direction -= 90;
            MovingDirection++;
            transform.localRotation = Quaternion.Euler(0, direction, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction += 90;
            MovingDirection--;
            transform.localRotation = Quaternion.Euler(0, direction, 0);
        }

        if (MovingDirection == -1)
            MovingDirection = 3;
        else if (MovingDirection == 4)
            MovingDirection = 0;

        animator.SetBool("Run", run);
    }
}
