using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class TutoAgent : Agent
{
	public GameObject ball;
	Vector3 ball_InitPos;

	public override void InitializeAgent()
	{
		ball_InitPos = ball.transform.position;
	}

	public override void CollectObservations()
	{
		//set state
		AddVectorObs(gameObject.transform.rotation.z);
		AddVectorObs(gameObject.transform.rotation.x);
		AddVectorObs(ball.transform.position - gameObject.transform.position);
		AddVectorObs(ball.GetComponent<Rigidbody>().velocity);
	}

	public override void AgentAction(float[] vectorAction, string textAction)
	{
		//set action
		gameObject.transform.Rotate(new Vector3(0, 0, 1), 2f * vectorAction[0]);
		gameObject.transform.Rotate(new Vector3(1, 0, 0), 2f * vectorAction[1]);

		//set reward
		if ((ball.transform.position.y - gameObject.transform.position.y) < -2f ||
			Mathf.Abs(ball.transform.position.x - gameObject.transform.position.x) > 3f ||
			Mathf.Abs(ball.transform.position.z - gameObject.transform.position.z) > 3f)
		{
			SetReward(-1f);
			Done();
		}
		else
		{
			SetReward(0.1f);
		}
	}

	public override void AgentReset()
	{
		ball.transform.position = ball_InitPos;
		ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
		ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

		gameObject.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
	}
}
