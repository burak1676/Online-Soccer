using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMover : MonoBehaviour
{

    BallPosition ballPosition;
    public GameObject ballPointer;
    public GameObject isPassedPointer;
    [SerializeField] float speed;
    MidPosition midPosition;
    public GameObject MidPointer;
    [SerializeField] GoalKeeperEnum goalKeeperEnum;
    float y;
    float z;
    [SerializeField] isPassed isPassed;


    void right()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -80), .1f);
    }

    void rightGround()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
    }

    void left()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, +80), .1f);
    }

    void leftGround()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
    }

    void mid()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
    }

    void others()
    {
        transform.position = Vector3.MoveTowards(transform.position, midPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
    }

    private void Awake()
    {
        ballPosition = ballPointer.GetComponent<BallPosition>();

        isPassed = isPassedPointer.GetComponent<isPassed>();

        midPosition = MidPointer.GetComponent<MidPosition>();
        z = transform.position.z;
        y = transform.position.y;
    }

    private void Update()
    {

        if(goalKeeperEnum == GoalKeeperEnum.Left)
        {
            if (isPassed.isAccess == true)
            {
                /*
                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);
                */

                if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y > 5) //left
                {
                    left();
                }

                else if (ballPosition.transform.position.x > 45 && ballPosition.transform.position.x < 55) //Mid
                {
                    mid();
                }

                else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y > 5) // right
                {
                    right();
                }
                else if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y <= 5)//leftGround
                {

                    leftGround();

                }
                else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y <= 5)//rightGround
                {
                    rightGround();
                }


                else if (ballPosition.transform.position.x >= 60 || ballPosition.transform.position.x < 40)//OtherShoot
                {

                    others();

                }


                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), .1f);

            }
        }
        else if(goalKeeperEnum == GoalKeeperEnum.Right)
        {
            if (isPassed.isAccess == true)
            {
                /*
                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);
                */

                if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y > 5) //left
                {
                    left();
                }

                else if (ballPosition.transform.position.x > 45 && ballPosition.transform.position.x < 55) //Mid
                {
                    mid();
                }

                else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y > 5) // right
                {
                    right();
                }

                else if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y <= 5)//left
                {
                    leftGround();
                }

                else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y <= 5)//right
                {
                    rightGround();
                }

                else if (ballPosition.transform.position.x >= 60 || ballPosition.transform.position.x < 40)
                {
                    others();
                }

                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), .1f);

            }
        }
    }
}