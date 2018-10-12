using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Specialisations
	{
		Warrior,
		Mage,
		Rogue,
		Archer
	}

public class Fighter : BaseMinion {

	
	void Start()
	{
		float maxHp = 150;
        float hp = 150;
        float morale = 1;
        float build = 0.1f;
        float speed = 1;
        float def = 1;
        float atk = 1;
        float range = 1;
	}

    public void Specialise(Specialisations specialisation)
    {

    }
}


