﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Aura.Mabi.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Entity
{
	public long EntityId;
	public string Name;
	public int RegionId;
	public int X;
	public int Z;
	public byte Direction;

	public Transform Transform;
}

public class Creature : Entity
{
	public CreatureStates State;

	public bool IsConversationNpc { get { return (State & (CreatureStates.GoodNpc | CreatureStates.NamedNpc | CreatureStates.Npc)) == (CreatureStates.GoodNpc | CreatureStates.NamedNpc | CreatureStates.Npc); } }
}
