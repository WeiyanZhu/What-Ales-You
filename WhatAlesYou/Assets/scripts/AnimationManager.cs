﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationManager : MonoBehaviour {
	
	public void Start()
	{
		//StartCoroutine(Test());
	}

	public IEnumerator Test()
	{
		SitDown();
		yield return new WaitForSeconds(1f);
		StandUp();
		yield return new WaitForSeconds(1f);
		Greet();
		yield return new WaitForSeconds(3f);
		Ashamed();
	}

	public void SitDown()
	{
		GetComponent<Animator>().SetBool("IsSitting", true);
	}

	public void StandUp()
	{
		GetComponent<Animator>().SetBool("IsSitting", false);
	}
	public void Drink()
	{
		StartCoroutine(Trigger("IsDrinking", 0.1f));
	}

	public void Ashamed()
	{
		StartCoroutine(Trigger("IsAshamed", 0.1f));
	}

	public void NodeOnce()
	{
		StartCoroutine(Trigger("IsRefusing", 0.1f));
	}
	public void StartNodding()
	{
		GetComponent<Animator>().SetBool("IsRefusing", true);
	}

	public void StopNodding()
	{
		GetComponent<Animator>().SetBool("IsRefusing", false);
	}
	public void Embarrass()
	{
		StartCoroutine(Trigger("IsEmbarrassed", 0.1f));
	}
	
	public void Greet()
	{
		StartCoroutine(Trigger("IsGreeting", 0.1f));
	}

	public void Pose()
	{
		StartCoroutine(Trigger("IsPosing", 0.1f));
	}

	public void ResetBool()
	{
		GetComponent<Animator>().SetBool("IsWalking", false);
		GetComponent<Animator>().SetBool("IsEmbarrassed", false);
		GetComponent<Animator>().SetBool("TurnRight", false);
		GetComponent<Animator>().SetBool("TurnLeft", false);
		GetComponent<Animator>().SetBool("IsAshamed", false);
		GetComponent<Animator>().SetBool("IsRefusing", false);
		GetComponent<Animator>().SetBool("IsIdle", false);
		GetComponent<Animator>().SetBool("IsDrinking", false);
		GetComponent<Animator>().SetBool("IsGreeting", false);
		GetComponent<Animator>().SetBool("IsPosing", false);

	}

	public IEnumerator Trigger(string name, float time)
	{
		GetComponent<Animator>().SetBool(name, true);
		yield return new WaitForSeconds(time);
		GetComponent<Animator>().SetBool(name, false);
	}

}