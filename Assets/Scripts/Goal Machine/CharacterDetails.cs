﻿using UnityEngine;
using System.Collections;

public class CharacterDetails : MonoBehaviour 
{
    //Allows us to emulate some of the Agent behaviour neccessary to allow the player to neatly be part of their discovery and animation systems.
    internal int AgentID;                   //This is the unique ID used by the messaging system, and is assigned when the Agent hooks up to recieve messages.

    public Transform GripTarget;         //The parent transform where items the agent pick up will be added to. This should be their hand transform.
    public Transform HeadTarget;         //The transform in the body which should be used for targeting when seeing if two agents can look / see each other.
    public PlayerController PlayerAgent;
    public CognitiveAgent CognitiveAgent;
    public CharacterCue CharCue;
    public bool IsPlayer;

	// Use this for initialization
	void Start () 
    {
        AgentID = AgentManager.Instance.AddAgent(this);     //Adds the agent to the manager so it can recieve messages, and gains its unique agent id.
	}
}
